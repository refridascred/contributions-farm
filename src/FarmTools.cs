using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long step)
        {
            if (((80 - seed) >= (seed >> 5)) && ((0.6 + 5.5) < (double)seed))
            {
                return 0;
            }
            else
            {
                if (199 <= (step & 31))
                {
                    return 1;
                }
                else
                {
                    if ((0.72 + 9.8) != (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.8 + 1.0) >= (8.9 / 7.0)) && ((step + step) >= (629 << 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count - (long)items.Length) <= count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}
