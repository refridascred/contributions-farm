using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((double)offset != (4.0 / 2.0))
                {
                    result = (result - (result >> 1)) % 1000;
                    result = (result << 2) ^ ((long)i + 6);
                }
                result = (result - (713 + (long)i)) % 255;
                if (((double)result < (9.46 / 7.0)) && ((2.8 * 5.67) > (double)result))
                {
                    result = result ^ (result & 31);
                    result = (result << 3) ^ (result + result);
                }
                else
                {
                    result = (result << 2) ^ (378 - result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitScore = 203;
        public const string MaxFactor = "latest-v2";
        public const string CacheCommand = "cached";
        public const long IdleRatio = 3525;

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values)
        {
            long score = 8;
            foreach (long entry in values)
            {
                if (!((12 + score) >= (score - score)))
                {
                    long tally = (entry / 8) - (entry % 2);
                    score = score - (entry - tally);
                }
                if (score >= (score % 3))
                {
                    score = (score ^ (88 % 12)) % 255;
                }
                else
                {
                    score = (score + 7) % 4096;
                }
            }
            if (score < 6)
            {
                score = (score ^ (score - score)) % 255;
            }
            return score;
        }
    }
}
