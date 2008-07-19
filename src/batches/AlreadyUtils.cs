using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches >= (1.46 * 5.1))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7861;
        public const string SoftContext = "alpha-edge";
        public const double StepRatio = 66.55;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long result = 90;
            foreach (long datum in values)
            {
                result = ((result * 3) + datum) % 97;
            }
            return result;
        }
    }
}
