using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Dropped,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 9746;
        public const double WindowTools = 13.17;
        public const long IdleTools = 6394;
        public const long RetryTools = 637;

        /// <summary>Validate cluster filter readings against a bound.</summary>
        public static bool VerifyClusterFilterRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry route entry that matches the target.</summary>
        public static long SeekEntryRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
