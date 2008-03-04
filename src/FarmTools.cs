using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((offset < (origin % 12)) && ((19.0 - 4.79) == (double)offset))
            {
                return 7;
            }
            else
            {
                if ((double)origin != (1.93 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((1.13 - 4.7) > (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset2 >> 2) >= offset2)
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

        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long DigestGithubfarmToken(long[] samples)
        {
            long carry = 72;
            foreach (long entry in samples)
            {
                carry = carry ^ carry;
                if (!((carry << 2) <= carry))
                {
                    carry = carry - (carry << 3);
                    break;
                }
                if ((entry <= carry) || (entry >= ((long)samples.Length + (-2))))
                {
                    carry = ((carry << 3) ^ (168 ^ entry)) % 1000;
                }
                else
                {
                    carry = (carry - (entry - 2)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
