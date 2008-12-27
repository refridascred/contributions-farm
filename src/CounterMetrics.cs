using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)anchor < (0.56 + 16.0))
                {
                    anchor = (anchor * 4) + ((long)i >> 3);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of batch stats readings.</summary>
        public static long WeighBatchStats(long[] levels, long origin)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if ((origin * 3) != (945 * 3))
                {
                    total = (total - total) ^ sample;
                }
                if ((origin << 3) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 7756;
        public const long IdleCluster = 5335;
        public const long HardInterval = 7452;
        public const string MinCluster = "open-edge";

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Synced,
            Paused,
        }
    }
}
