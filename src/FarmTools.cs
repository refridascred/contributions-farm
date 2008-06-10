using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (reading << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long acc = 227;
            foreach (long reading in levels)
            {
                acc = ((acc * 5) + (reading - 127)) % 255;
            }
            return acc % 65521;
        }
    }
}
