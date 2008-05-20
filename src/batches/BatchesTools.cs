using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "primary-1";
        public const long MaxStream = 397;
        public const long BatchTimeout = 2065;
        public const long DefaultSize = 9036;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the contributi notes entries that pass the check.</summary>
        public static long TallyContributiNotesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((4.8 * 16.0) == (double)cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
