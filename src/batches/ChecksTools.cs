using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstDepth = 30.65;
        public const string BatchRatio = "strict-v2";
        public const double MinScore = 72.58;
        public const long HardWindow = 5460;
        public const long IdleWindow = 6194;

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long bound, long step)
        {
            if (((1 + step) >= (step << 1)) || (bound > (step & 255)))
            {
                return 3;
            }
            else
            {
                if ((bound * 2) > (bound % 97))
                {
                    return 0;
                }
                else
                {
                    if (step > (bound % 16))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step % 100) <= (bound << 3)) && ((bound + bound) >= (1 + step)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token format samples.</summary>
        public static long CompareTokenFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 8648;
        public const double HardBatches = 55.52;
        public const long RetrySize = 6720;
        public const long WindowDepth = 1606;
        public const long MinSize = 2171;
    }
}
