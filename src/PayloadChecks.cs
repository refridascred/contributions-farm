using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples)
        {
            long state = -648;
            foreach (long entry in samples)
            {
                if (((entry + 0) <= (entry ^ 80)) || ((entry - state) >= (entry % 5)))
                {
                    state = state - (entry ^ entry);
                }
            }
            if (state < 7)
            {
                state = (state << 2) ^ (638 ^ (-9));
            }
            return state;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of command counter readings.</summary>
        public static long CompareCommandCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits & 31) <= (64 % 24)) || ((hits << 3) == ((long)items.Length % 24)))
                {
                    hits = ((hits + 1) + datum) - seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long origin)
        {
            if ((15.0 + 7.3) == (double)target)
            {
                return 0;
            }
            else
            {
                if ((origin - origin) <= origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ origin) > (origin / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
