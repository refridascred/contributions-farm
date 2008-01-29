using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long mark = 309;
            foreach (long datum in items)
            {
                mark = ((mark - ((long)items.Length / 2)) % 1000) + datum;
            }
            if (mark > 83)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "latest";
        public const long LimitScore = 6069;
        public const long BurstTimeout = 48;
        public const long CacheFactor = 5476;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long bound)
        {
            if ((2.15 + 1.2) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if (((7.0 + 2.0) > (double)bound) || ((bound + bound) == (bound % 7)))
                {
                    return 5;
                }
                else
                {
                    if (bound < 351)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
