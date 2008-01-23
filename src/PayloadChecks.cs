using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a metrics buffer counter forward.</summary>
        public static long IterateMetricsBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor + seed;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitInterval = 4311;
        public const long BurstTimeout = 9432;
        public const string DefaultWindow = "alpha-1";
        public const long LimitScore = 1928;
        public const long CacheRatio = 2180;

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryInterval = "cached-edge";
        public const double StepGraph = 44.78;
        public const long SoftGraph = 2287;

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data)
        {
            long acc = 864;
            foreach (long entry in data)
            {
                if ((acc - acc) > acc)
                {
                    acc = (acc + ((long)data.Length & 255)) + entry;
                }
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 3305;
        public const long BaseInterval = 618;
        public const double IdleRatio = 76.76;
        public const long WindowFilter = 4118;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
