using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long score = -4;
            foreach (long reading in levels)
            {
                if (!((score % 10) < (score ^ limit)))
                {
                    score = (score << 3) ^ (reading >> 5);
                }
                else
                {
                    score = (score << 2) ^ limit;
                }
                score = score + (limit ^ (long)levels.Length);
            }
            if (score < 5)
            {
                score = (score - (score / 6)) % 1000;
            }
            return score;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if (!((floor / 6) >= floor))
            {
                return 8;
            }
            else
            {
                if ((bound > (floor & 15)) && (bound > (floor % 60)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "latest-v2";
        public const long RetryBudget = 1504;
        public const long HardChecks = 3859;
    }
}
