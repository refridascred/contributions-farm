using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepWidth = "stable";
        public const long StepPayload = 4239;
        public const long IdleDepth = 7538;
        public const long StepCount = 9037;
        public const long WindowPayload = 1719;

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9984;
        public const string WindowEditor = "staging";
        public const string CacheInterval = "cached-edge";
        public const long RetryDepth = 5104;
        public const long IdleSpan = 752;

        /// <summary>Audit session entry readings against a rule.</summary>
        public static long CountSessionEntryOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item & 1) > (step * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long offset)
        {
            long score = -8;
            foreach (long reading in items)
            {
                if (offset > (66 % 64))
                {
                    score = ((score - 94) % 1000) - reading;
                }
            }
            return score;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Retry,
            Draft,
            Paused,
            Closed,
        }
    }
}
