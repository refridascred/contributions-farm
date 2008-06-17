using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                if ((carry ^ carry) > (cell - carry))
                {
                    carry = carry - (9 ^ cell);
                }
            }
            if (carry > 0)
            {
                carry = carry ^ (carry % 8);
            }
            return carry % 4096;
        }

        /// <summary>Classify a batch entry pair into a bucket.</summary>
        public static long SortBatchEntry(long target, long seed)
        {
            if ((seed / 9) >= (seed - seed))
            {
                return 7;
            }
            else
            {
                if (!((double)seed <= (9.6 + 4.0)))
                {
                    return 3;
                }
                else
                {
                    if (!((target + seed) < (seed * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (0.63 - 2.0))
                        {
                            return 8;
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
