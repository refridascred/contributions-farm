using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "staging-1";
        public const long RetryScore = 6613;
        public const long MinMetrics = 8068;
        public const long WindowFactor = 3870;
        public const double MaxMetrics = 57.67;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count record stream pairs that satisfy a relation.</summary>
        public static long OverlapRecordStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
