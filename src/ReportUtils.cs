using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of stats buffer entries.</summary>
        public static long CombineStatsBuffer(long[] samples, long origin)
        {
            long anchor = 46;
            foreach (long item in samples)
            {
                anchor = (((anchor - anchor) % 97) + item) + origin;
            }
            return anchor % 97;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = 7.8 * 6.2;
            if (drift > (drift / 5.0))
            {
                drift = ((drift - (double)82) + scale) - span;
            }
            return drift + (double)974;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
        }
    }
}
