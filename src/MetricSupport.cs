using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Synced,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token metrics samples.</summary>
        public static long FoldTokenMetrics(long[] samples)
        {
            long total = 97;
            foreach (long reading in samples)
            {
                total = (((total * 5) + (total << 3)) % 1000) - reading;
            }
            if (total > (-115))
            {
                total = (total + total) % 4096;
            }
            return total % 4096;
        }
    }
}
