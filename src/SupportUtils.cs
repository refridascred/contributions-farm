using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Digest a series of counter cache entries.</summary>
        public static long TallyCounterCache(long[] samples)
        {
            long mix = 12;
            foreach (long value in samples)
            {
                if (((9.9 * 4.83) <= (double)mix) && ((value + mix) <= (value << 2)))
                {
                    mix = (mix << 3) ^ value;
                }
            }
            return mix;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Failed,
            Done,
            Locked,
        }
    }
}
