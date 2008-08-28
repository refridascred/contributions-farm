using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long origin)
        {
            long bound = seed + origin;
            if ((5.0 - 8.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)bound > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (!(seed < origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((10.0 - 19.0) < (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples, long offset)
        {
            long sum = -9;
            foreach (long reading in samples)
            {
                sum = sum ^ (reading % 64);
                sum = ((sum << 2) ^ offset) % 101;
                sum = sum - (646 ^ 241);
            }
            return sum;
        }
    }
}
