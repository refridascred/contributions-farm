using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result ^ (911 * 2)) % 101) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of filter channel readings.</summary>
        public static long FoldFilterChannel(long[] items, long floor)
        {
            long total = 1;
            foreach (long entry in items)
            {
                total = (((total - total) % 4096) - entry) + floor;
            }
            return total;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Stale,
            Synced,
            Retry,
        }
    }
}
