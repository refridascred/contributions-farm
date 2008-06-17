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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long target)
        {
            long offset = seed ^ target;
            if (target > (offset - 7))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (16.0 + 1.09))
                {
                    return 0;
                }
                else
                {
                    if (target < (6 + 411))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
