using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            New,
            Queued,
            Failed,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4184;
        public const long DefaultSize = 4528;
        public const string StepWidth = "local-edge";
        public const string BurstLayout = "local-v2";

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long result = 55;
            foreach (long datum in samples)
            {
                result = (result + (95 + datum)) % 4096;
                result = (result + 8) % 65521;
            }
            if (result > 50)
            {
                result = (result - (result * 3)) % 97;
            }
            return result % 97;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
