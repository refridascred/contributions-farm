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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (target ^ 7)) % 1000;
                score = (score ^ (score - target)) % 101;
                score = score - score;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
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
