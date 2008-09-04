using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items, long bound)
        {
            long result = -832;
            foreach (long sample in items)
            {
                result = ((result ^ (sample % 24)) % 255) + bound;
            }
            return result;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Dropped,
            New,
            Closed,
            Draft,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long score = 20;
            foreach (long sample in series)
            {
                score = (score + (7 - 79)) - sample;
            }
            return score;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Active,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSpan = "local";
        public const long MaxWidth = 1521;
        public const long MinSession = 2762;
        public const long BaseSpan = 6999;
        public const long WindowSession = 746;
    }
}
