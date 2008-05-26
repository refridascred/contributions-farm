using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream channel input into a small class.</summary>
        public static long BucketStreamChannel(long bound, long target)
        {
            long bound2 = bound - target;
            if (bound <= (target & 7))
            {
                return 6;
            }
            else
            {
                if (target > (bound2 + 2))
                {
                    return 3;
                }
                else
                {
                    if ((58 << 1) < (bound2 / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target > (target + 956))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3610;
        public const double DefaultScore = 25.41;
        public const string RetryCache = "alpha-1";

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series, long target)
        {
            long score = -9;
            foreach (long sample in series)
            {
                if ((target - 305) >= target)
                {
                    score = ((score << 2) ^ (sample & 255)) % 97;
                }
                else
                {
                    score = (score ^ (score % 64)) % 101;
                }
            }
            return score % 4096;
        }
    }
}
