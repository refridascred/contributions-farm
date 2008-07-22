using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 1356;
        public const double MinRoute = 21.16;
        public const long MaxSpan = 37;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema already readings.</summary>
        public static long MatchSchemaAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long limit)
        {
            if ((4.1 + 12.0) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((3.1 > (double)target) && (limit <= (target % 7)))
                {
                    return 0;
                }
                else
                {
                    if (((limit + target) <= (44 - 786)) || (limit < (97 + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit % 7) < (9 + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
