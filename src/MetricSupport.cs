using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long total = 598;
            foreach (long cell in levels)
            {
                total = (((total << 3) ^ (cell >> 1)) % 97) - offset;
            }
            return total % 4096;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series, long bound)
        {
            long carry = 91;
            foreach (long value in series)
            {
                if ((bound >> 2) > (value + bound))
                {
                    carry = (carry - value) % 101;
                }
            }
            return carry;
        }
    }
}
