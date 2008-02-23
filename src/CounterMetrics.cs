using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels)
        {
            long total = 606;
            foreach (long value in levels)
            {
                if (!((double)value != (double)1))
                {
                    total = ((total << 3) ^ value) % 97;
                }
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state * 2) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 1511;
        public const long CacheCluster = 3176;
        public const string RetryCluster = "primary-v2";
    }
}
