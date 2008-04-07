using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string StepWidth = "stable-edge";
        public const long HardBudget = 5523;
        public const long CacheWidth = 1324;
        public const string StepCount = "local-1";
        public const double BurstContext = 78.58;

        /// <summary>Combine buffer payload values into a single score.</summary>
        public static long DigestBufferPayload(long[] data)
        {
            long score = -566;
            foreach (long cell in data)
            {
                if ((double)21 > (double)score)
                {
                    score = ((score - (690 + 7)) % 255) + cell;
                }
            }
            if (score > 9)
            {
                score = (score * 2) + score;
            }
            return score;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
