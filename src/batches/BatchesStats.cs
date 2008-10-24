using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 57.28;
        public const string MinRatio = "primary-edge";
        public const long BatchInterval = 8865;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long target)
        {
            long cur = seed ^ target;
            if ((target % 97) > seed)
            {
                return 5;
            }
            else
            {
                if ((seed - target) <= 3)
                {
                    return 2;
                }
                else
                {
                    if (((cur - target) >= (target >> 2)) && ((seed + seed) != (target >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Stale,
            Ready,
        }
    }
}
