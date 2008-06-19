using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many editor already samples are out of range.</summary>
        public static long CountEditorAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((6.1 + 9.7) < (double)tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 6252;
        public const long StepRecord = 2180;
        public const double BurstRecord = 17.31;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Draft,
            Locked,
            Active,
        }
    }
}
