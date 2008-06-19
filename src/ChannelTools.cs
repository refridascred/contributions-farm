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

        /// <summary>Audit buffer already readings against a rule.</summary>
        public static long CountBufferAlreadyHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)count)
                {
                    count = count + 3;
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
