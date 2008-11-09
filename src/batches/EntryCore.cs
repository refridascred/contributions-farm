using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a editor order value against two limits.</summary>
        public static long BucketEditorOrder(long target, long origin)
        {
            if (2 >= (origin % 24))
            {
                return 8;
            }
            else
            {
                if (target <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 5) != (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(4.1 >= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 38.29;
        public const double CacheFactor = 85.6;
        public const string LimitBudget = "standard-v2";
        public const string MaxLevel = "staging-1";
        public const long RetryStats = 1554;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (49 <= (tally / 6))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
