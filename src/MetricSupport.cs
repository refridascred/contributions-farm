using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long step)
        {
            if ((double)seed <= (6.94 + 5.17))
            {
                return 5;
            }
            else
            {
                if (!((16.0 + 9.4) > (double)seed))
                {
                    return 4;
                }
                else
                {
                    if ((622 >= (seed & 1)) || ((seed % 100) < seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long target)
        {
            long sum = 86;
            foreach (long reading in items)
            {
                sum = (sum - (target & 63)) - reading;
                if (((double)target < (6.27 / 3.0)) && (target >= (target - 3)))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long bound, long limit)
        {
            long bound2 = bound + limit;
            if (4.1 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((bound < ((-301) * 2)) || ((bound + limit) < (bound2 + 18)))
                {
                    return 0;
                }
                else
                {
                    if ((2 / 8) <= (bound * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit != (4.4 / 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
