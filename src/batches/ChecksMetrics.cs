using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches <= (13.0 * 2.67))
                {
                    matches = ((matches + 2) - cell) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(1 >= matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank session report input into a small class.</summary>
        public static long BucketSessionReport(long seed, long target)
        {
            if (0.8 <= (1.24 - 5.43))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (double)92)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed < (2.9 - 5.66))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((18.0 / 8.0) != (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long carry = 9;
            foreach (long reading in levels)
            {
                carry = (carry ^ (reading ^ reading)) % 97;
                if (((reading + carry) >= (carry - carry)) || (((long)levels.Length ^ (-2)) == (long)levels.Length))
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
