using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchSpan = 2.81;
        public const string BurstDepth = "stable";
        public const long IdleRoute = 5424;
        public const double CacheSpan = 96.24;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long limit)
        {
            long diff = target ^ limit;
            if (1.95 < (double)target)
            {
                return 1;
            }
            else
            {
                if (((limit >> 4) > limit) || ((target ^ diff) != (diff + diff)))
                {
                    return 2;
                }
                else
                {
                    if (!((diff & 7) >= (152 << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
