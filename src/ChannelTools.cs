using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long seed2)
        {
            if ((double)seed >= 2.37)
            {
                return 7;
            }
            else
            {
                if (((double)seed > (6.6 - 11.0)) || (seed2 < (seed2 % 8)))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed < (2.8 + 2.2)) && ((double)seed2 > 9.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long target)
        {
            long sum = 88;
            foreach (long datum in levels)
            {
                sum = (((sum << 2) ^ ((long)levels.Length & 1)) - datum) - target;
            }
            return sum;
        }
    }
}
