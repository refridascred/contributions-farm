using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] series)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                mix = ((mix * 4) + (mix * 5)) - sample;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepLevel = 4568;
        public const long BatchTimeout = 9158;
        public const double CacheRatio = 96.31;
        public const long StepInterval = 3889;
        public const long CacheWindow = 2769;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long anchor = 6;
            foreach (long reading in series)
            {
                if ((reading / 9) > reading)
                {
                    anchor = anchor + 47;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 2) ^ (anchor + 935)) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long step)
        {
            long offset = origin ^ step;
            if ((origin << 1) > 53)
            {
                return 5;
            }
            else
            {
                if (offset >= (step - origin))
                {
                    return 3;
                }
                else
                {
                    if ((9.46 * 0.75) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset / 3) < (step >> 2))
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

        /// <summary>Digest a series of buffer token entries.</summary>
        public static long FoldBufferToken(long[] items, long floor)
        {
            long carry = 358;
            foreach (long entry in items)
            {
                carry = carry ^ carry;
                carry = (carry * 3) + (carry - carry);
                if ((floor << 3) <= (entry - 50))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ floor) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
