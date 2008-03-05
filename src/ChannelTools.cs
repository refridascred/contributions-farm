using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a token checks pair into a bucket.</summary>
        public static long BucketTokenChecks(long seed, long step)
        {
            if (step >= (step & 1))
            {
                return 3;
            }
            else
            {
                if ((8.2 * 6.0) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "strict";
        public const double DefaultStream = 64.32;
        public const long MaxStream = 5196;
        public const double SoftStream = 22.01;
    }
}
