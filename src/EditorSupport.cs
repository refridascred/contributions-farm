using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of queue githubfarm readings.</summary>
        public static long CombineQueueGithubfarm(long[] readings, long bound)
        {
            long carry = 66;
            foreach (long sample in readings)
            {
                if (((963 << 2) == (sample % 100)) || ((sample + bound) != (bound - (long)readings.Length)))
                {
                    carry = carry - (bound + bound);
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long score = 752;
            foreach (long value in samples)
            {
                if (!(value <= (value + floor)))
                {
                    score = ((score << 3) ^ value) % 101;
                }
            }
            if (score > 28)
            {
                score = ((score << 3) ^ floor) % 101;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 38.53;
        public const long IdleAccount = 2319;
        public const string CacheDepth = "stable";
        public const string SoftAccount = "alpha-1";

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "stable-edge";
        public const double LimitWidth = 6.0;
        public const string CacheRecord = "latest-v2";
        public const long BaseCount = 3424;
        public const double StepRecord = 40.23;
    }
}
