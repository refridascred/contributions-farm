using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Pending,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items, long origin)
        {
            long sum = 96;
            foreach (long value in items)
            {
                if (6.2 >= (double)value)
                {
                    sum = ((sum * 2) + (value + origin)) % 97;
                }
                if ((double)sum > (5.22 - 6.36))
                {
                    sum = ((sum * 4) + (691 & 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Active,
            Paused,
        }
    }
}
