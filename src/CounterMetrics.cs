using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long floor)
        {
            if ((limit % 12) > 89)
            {
                return 1;
            }
            else
            {
                if (!((9.0 - 2.01) != (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((4 ^ 345) >= (limit & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor >= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "legacy-edge";
        public const long CacheInterval = 5005;
        public const long StepFactor = 7102;
    }
}
