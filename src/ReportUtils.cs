using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinSpan = 7490;
        public const string CacheSize = "staging-edge";
        public const long SoftCount = 9957;
        public const long IdleSpan = 7959;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 97) <= matches))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Failed,
            Pending,
            Active,
            Synced,
        }
    }
}
