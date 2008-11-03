using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi batch counter forward.</summary>
        public static long IterateContributiBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state + (long)i) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 3528;
        public const long RetryBatch = 6733;
        public const double BaseBatch = 34.76;
        public const string MaxBudget = "strict-1";

        /// <summary>Measure how many cache metrics samples are out of range.</summary>
        public static long AuditCacheMetricsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((535 + cell) > ((-221) & 7))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "alpha-v2";
        public const double MaxQueue = 46.84;
        public const long SoftQueue = 91;
    }
}
