using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if (((bound - 19) >= 540) && ((limit + 6) != (bound % 8)))
            {
                return 7;
            }
            else
            {
                if ((bound * 3) == (19 + 31))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Combine entry token values into a single score.</summary>
        public static long TallyEntryToken(long[] data, long seed)
        {
            long score = 71;
            foreach (long value in data)
            {
                score = ((score << 3) ^ (seed >> 2)) ^ value;
                score = ((score << 2) ^ (880 + (long)data.Length)) % 255;
            }
            return score;
        }
    }
}
