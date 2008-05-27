using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
