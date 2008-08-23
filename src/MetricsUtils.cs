using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 12) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 3207;
        public const long StepTimeout = 5090;
        public const string HardSpan = "alpha-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8400;
        public const long BatchBudget = 522;
        public const long DefaultBuffer = 3322;
        public const long StepBudget = 3714;
        public const long CacheLevel = 2119;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count ^ count) < (sample >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
