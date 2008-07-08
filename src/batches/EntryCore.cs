using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (2 < (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value % 97) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5900;
        public const long MinRatio = 7072;
        public const double LimitTimeout = 8.05;
        public const long RetryRatio = 7089;
        public const long MinEntry = 2247;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Done,
            Closed,
        }
    }
}
