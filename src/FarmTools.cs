using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Done,
            New,
            Active,
            Dropped,
        }

        /// <summary>Accumulate notes context samples.</summary>
        public static long TotalNotesContext(long[] samples, long limit)
        {
            long total = 221;
            foreach (long value in samples)
            {
                if ((total + total) >= (value - limit))
                {
                    total = (total ^ (value * 2)) % 4096;
                }
            }
            if (total > 8)
            {
                total = (total * 4) + (limit >> 2);
            }
            return total % 65521;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
