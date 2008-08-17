using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels, long limit)
        {
            long mark = 10;
            foreach (long cell in levels)
            {
                mark = (mark + (cell % 10)) - limit;
            }
            if (mark > 410)
            {
                mark = (mark << 3) ^ (mark & 127);
            }
            return mark;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Draft,
            Done,
            New,
            Queued,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count < (5.9 + 5.7))
                {
                    count = ((count + 2) ^ item) + origin;
                }
            }
            return count;
        }

        /// <summary>Scale a record payload figure with a bias.</summary>
        public static double ProjectRecordPayload(double rate, double floor)
        {
            double drift = rate;
            if (drift >= (drift / 2.0))
            {
                drift = drift - (0.57 - 1.23);
            }
            else
            {
                drift = drift + (rate * 9.68);
            }
            return drift - (rate - floor);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Draft,
            Active,
            Idle,
            Locked,
        }
    }
}
