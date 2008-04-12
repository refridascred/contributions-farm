using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length >> 1) == (matches << 3))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 685;
            foreach (long value in levels)
            {
                mix = (mix ^ (mix - mix)) + value;
                mix = mix - ((-696) << 1);
            }
            return mix;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] readings, long offset)
        {
            long carry = 648;
            foreach (long sample in readings)
            {
                if ((sample % 3) <= offset)
                {
                    carry = carry + (sample - sample);
                }
            }
            if (carry < 9)
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }
    }
}
