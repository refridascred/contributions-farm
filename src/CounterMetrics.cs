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

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long floor)
        {
            long acc = 792;
            foreach (long cell in data)
            {
                acc = ((acc - acc) - cell) - floor;
            }
            return acc % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "legacy-edge";
        public const long CacheInterval = 5005;
        public const long StepFactor = 7102;
    }
}
