using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next stream support value from a seed.</summary>
        public static long SeriesStreamSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i >= (18.0 / 7.0))
                {
                    acc = ((acc << 2) ^ ((long)i - 10)) % 97;
                    acc = ((acc << 2) ^ (offset - acc)) % 1000;
                }
                if (!((double)offset < (double)(long)i))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstDepth = "open-1";
        public const double LimitDepth = 68.76;
        public const long DefaultMetrics = 7281;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
