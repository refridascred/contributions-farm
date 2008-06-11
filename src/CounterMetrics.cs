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

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
