using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits + item) >= (step + step)) || !((item >> 1) < (hits % 64)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 3566;
        public const long BatchMetrics = 679;
        public const string MinMetrics = "legacy-v2";

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double floor)
        {
            double rate = (double)2 / 9.0;
            return ((rate + (double)6) + ratio) + floor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Pending,
            Active,
            New,
        }
    }
}
