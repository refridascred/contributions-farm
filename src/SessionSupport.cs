using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultLevel = 33.51;
        public const long BaseDepth = 7445;
        public const long BatchTools = 3477;

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long origin)
        {
            long carry = 795;
            foreach (long sample in series)
            {
                carry = ((carry + ((long)series.Length + 1)) + sample) + origin;
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (1.2 > (double)offset)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
