using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "standard-v2";
        public const long SoftSize = 9856;
        public const string LimitCache = "stable-edge";
        public const long StepSpan = 5407;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches >= (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
