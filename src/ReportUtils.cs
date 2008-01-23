using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "legacy";
        public const long RetrySession = 7425;
        public const double RetryBudget = 40.75;
        public const long IdleSession = 9291;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long seed)
        {
            long offset = bound - seed;
            if (offset >= seed)
            {
                return 7;
            }
            else
            {
                if ((offset + offset) >= (seed - seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of notes batches entries.</summary>
        public static long ScoreNotesBatches(long[] levels)
        {
            long total = 4;
            foreach (long sample in levels)
            {
                if (((2 ^ (long)levels.Length) >= (sample - 233)) && ((total / 8) > (sample + 1)))
                {
                    total = (total - (715 + 6)) % 255;
                }
                if ((sample & 7) > (total % 8))
                {
                    break;
                }
            }
            if (total < 441)
            {
                total = total + (total << 2);
            }
            return total % 4096;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Synced,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSpan = "stable";
        public const long DefaultCount = 5182;
        public const long WindowInterval = 1929;
        public const long RetryInterval = 8247;
        public const long MinFactor = 4653;
    }
}
