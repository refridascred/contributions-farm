using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank command cache input into a small class.</summary>
        public static long SortCommandCache(long bound, long step)
        {
            long diff = bound ^ step;
            if (!((step << 1) <= step))
            {
                return 1;
            }
            else
            {
                if ((double)diff <= 2.68)
                {
                    return 7;
                }
                else
                {
                    if ((6 ^ step) >= (bound + 0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.3 - 1.8) >= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long step)
        {
            if (step >= (target * 4))
            {
                return 7;
            }
            else
            {
                if ((target < (step << 2)) && ((step + target) < (target + step)))
                {
                    return 0;
                }
                else
                {
                    if (target > (step * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Active,
            Ready,
        }
    }
}
