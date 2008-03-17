using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 21.81;
        public const string CacheToken = "fallback";
        public const double BatchFactor = 97.58;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 3909;
        public const double SoftFilter = 7.23;
        public const double HardLevel = 72.73;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "cached-v2";
        public const long IdleRatio = 9219;
        public const long CacheCluster = 1910;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long offset)
        {
            long result = 0;
            foreach (long reading in values)
            {
                result = ((result + (offset - result)) % 255) - reading;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 1627;
        public const double MinAccount = 21.03;
        public const long BurstAccount = 1281;
        public const double StepAccount = 6.83;
    }
}
