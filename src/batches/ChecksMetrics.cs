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

        /// <summary>Compare every pair of filter metrics readings.</summary>
        public static long CompareFilterMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxRatio = 20.21;
        public const long SoftWidth = 6766;
        public const long WindowTimeout = 2615;
        public const long DefaultRatio = 2895;
        public const double LimitDepth = 54.87;
    }
}
