using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((952 * 5) <= target)
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long result = 198;
            foreach (long sample in values)
            {
                if (result < (result - sample))
                {
                    result = result + (sample % 12);
                }
                else
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }
    }
}
