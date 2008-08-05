using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed >> 5) < (matches + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long limit)
        {
            if (((origin ^ limit) >= (limit & 31)) && ((origin % 97) == (origin << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((double)origin < (5.0 * 1.0)) && ((double)limit != (14.0 / 9.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((45 ^ origin) == (origin >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token layout readings.</summary>
        public static long PairTokenLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSize = 4243;
        public const double RetryFarm = 47.46;
        public const string MaxBudget = "alpha-1";
        public const long WindowInterval = 1563;
    }
}
