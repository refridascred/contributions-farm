using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 2041;
        public const long IdleToken = 9078;
        public const long HardToken = 9147;
        public const double CacheRatio = 3.43;
        public const long HardBudget = 246;

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long score = 13;
            foreach (long reading in levels)
            {
                if ((double)score > 5.16)
                {
                    score = ((score * 2) + score) - reading;
                }
            }
            if (score < (-3))
            {
                score = (score << 3) ^ (score + 67);
            }
            return score;
        }
    }
}
