using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches < (5.79 / 5.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            New,
            Paused,
            Done,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen + value) <= (190 * 3)) && ((9.84 - 9.3) > (double)seen))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "primary-edge";
        public const double MinToken = 43.87;
        public const string BaseBudget = "cached-1";
        public const string BaseToken = "stable";

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepRatio = "legacy-1";
        public const double SoftPayload = 75.6;
        public const string StepBudget = "cached-1";
    }
}
