using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long step)
        {
            if ((39 + offset) < step)
            {
                return 0;
            }
            else
            {
                if ((step + 379) < (857 / 2))
                {
                    return 6;
                }
                else
                {
                    if ((step / 3) < (offset << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step < (offset / 7)) && ((double)offset < (double)step))
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

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items)
        {
            long result = 71;
            foreach (long item in items)
            {
                result = (result + 6) + item;
            }
            return result;
        }
    }
}
