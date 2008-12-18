using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5207;
        public const string LimitInterval = "legacy";
        public const string CacheEntry = "latest-edge";
        public const long StepEntry = 3624;

        /// <summary>Grade a command layout value against two limits.</summary>
        public static long ClassifyCommandLayout(long offset, long seed)
        {
            if ((seed < (seed + offset)) || ((offset << 2) <= (seed % 97)))
            {
                return 1;
            }
            else
            {
                if ((double)offset < (4.45 + 10.0))
                {
                    return 2;
                }
                else
                {
                    if (((7.3 - 20.0) >= (double)seed) && ((offset - offset) > (offset + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - seed) > 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long score = -4;
            foreach (long sample in items)
            {
                if (!((double)score >= (double)floor))
                {
                    score = (((score * 5) + (8 >> 5)) % 255) ^ sample;
                }
                score = score + (floor % 5);
            }
            if (score > 77)
            {
                score = (score ^ score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryDepth = 8.77;
        public const double WindowFactor = 4.51;
        public const double IdleProfile = 40.22;
        public const string RetryProfile = "fallback-v2";
    }
}
