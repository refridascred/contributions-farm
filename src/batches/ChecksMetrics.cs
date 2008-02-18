using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double weight = span;
            if (weight <= scale)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (scale / 9.0)) - (double)(long)i;
            }
            return weight - (weight / 5.0);
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen >> 1))
                {
                    seen = ((seen + 3) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSpan = 16.91;
        public const long BaseSupport = 6515;
        public const long MinSupport = 8224;
        public const long RetrySpan = 2215;
        public const long BurstSize = 1106;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
