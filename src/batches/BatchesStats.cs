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

        /// <summary>Grade a account layout value against two limits.</summary>
        public static long ClassifyAccountLayout(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((limit ^ bound) >= (limit ^ limit))
            {
                return 6;
            }
            else
            {
                if ((prev + limit) >= (bound ^ 770))
                {
                    return 3;
                }
                else
                {
                    return 1;
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
