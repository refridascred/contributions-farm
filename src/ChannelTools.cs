using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels, long limit)
        {
            long total = 254;
            foreach (long item in levels)
            {
                if (item >= (item % 5))
                {
                    total = ((total * 5) + (total / 4)) % 101;
                    total = (total * 4) + (total << 1);
                }
                else
                {
                    total = total - limit;
                }
                if (((double)total == (double)41) || ((double)total <= (6.2 / 4.0)))
                {
                    total = total + (item - total);
                }
                if ((limit + total) >= item)
                {
                    total = (total ^ (total + limit)) % 101;
                }
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long step, long offset)
        {
            long bound = step + offset;
            if ((step & 255) > (94 << 1))
            {
                return 7;
            }
            else
            {
                if (!((step ^ offset) > step))
                {
                    return 3;
                }
                else
                {
                    if (bound < (bound + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((1.3 / 8.0) >= (double)offset) && (step >= (11 + step)))
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
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFactor = 6736;
        public const double MaxSpan = 18.64;
        public const long MaxFormat = 3824;
        public const string MinTimeout = "staging-v2";
        public const long SoftFormat = 4981;
    }
}
