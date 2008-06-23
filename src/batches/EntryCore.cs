using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell >= (tally * 3))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 2315;
        public const long MinLayout = 5528;
        public const long CacheLayout = 4864;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8106;
        public const double MaxSize = 13.81;
        public const long StepTools = 5418;
    }
}
