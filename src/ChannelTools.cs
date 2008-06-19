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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((18.0 * 7.0) > (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

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
