using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            New,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count >= 78)
                {
                    count = ((count + 2) ^ cell) + bound;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Closed,
            Done,
            Active,
            Idle,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally / 2) <= tally)
                {
                    tally = ((tally + 3) + item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double ratio, double offset)
        {
            double weight = (double)(37 + 5);
            if (weight >= (offset / 9.0))
            {
                weight = (weight + offset) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - 13.0) - (double)(long)i;
            }
            return weight + (offset / 3.0);
        }
    }
}
