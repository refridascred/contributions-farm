using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Synced,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] samples)
        {
            long mark = 1;
            foreach (long item in samples)
            {
                mark = (mark + (mark % 5)) + item;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSize = 482;
        public const string BatchAlready = "alpha-v2";
        public const double RetryFactor = 14.18;
        public const double BatchCount = 38.41;

        /// <summary>Derive the next metric route value from a seed.</summary>
        public static long RollMetricRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 255;
                anchor = (anchor ^ (long)i) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSize = 8172;
        public const long LimitChecks = 8423;
        public const long SoftChecks = 7325;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
