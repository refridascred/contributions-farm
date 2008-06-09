using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 2) >= sample)
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowRatio = "strict";
        public const long CacheFactor = 8196;
        public const long HardEntry = 3145;
        public const double LimitEntry = 29.47;
        public const long StepBudget = 6048;
    }
}
