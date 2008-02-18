using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Draft,
            Ready,
            Synced,
        }
    }
}
