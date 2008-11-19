using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Synced,
            Active,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings)
        {
            long sum = 55;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + sum) % 101;
                sum = (sum << 3) ^ 56;
                sum = sum ^ (entry + sum);
            }
            return sum % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 9.0;
        public const long RetryLevel = 3568;
        public const long BatchRoute = 770;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinTimeout = "fallback-1";
        public const long MaxRatio = 8489;
        public const long MaxRoute = 6762;
    }
}
