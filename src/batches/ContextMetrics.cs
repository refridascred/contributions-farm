using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long offset)
        {
            if (!((offset + origin) > (offset ^ 7)))
            {
                return 3;
            }
            else
            {
                if ((origin * 5) < (offset - origin))
                {
                    return 2;
                }
                else
                {
                    if (((offset + 6) == (origin + offset)) || (offset < (origin - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - acc) < 6)
                {
                    break;
                }
                else
                {
                    acc = (acc * 4) + (85 - (long)i);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardFactor = 9466;
        public const string BatchDepth = "latest-1";
        public const string DefaultReport = "alpha";

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 4700;
        public const long SoftInterval = 105;
        public const long SoftSize = 8759;
        public const long LimitStream = 4582;
    }
}
