using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a account contributi pair into a bucket.</summary>
        public static long SortAccountContributi(long offset, long seed)
        {
            if ((offset - offset) <= (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (0.64 * 9.86))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ offset) >= (seed ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset + seed) <= (offset << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSize = 2607;
        public const long RetryOrder = 1475;
        public const long BaseInterval = 8357;
        public const double MaxBudget = 73.67;
        public const string BurstBudget = "fallback";
    }
}
