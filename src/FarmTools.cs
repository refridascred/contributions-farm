using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally - reading) <= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Closed,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3184;
        public const long WindowToken = 1646;
        public const long StepDepth = 1371;
        public const long BatchToken = 3115;
        public const long BatchTimeout = 863;
    }
}
