using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((long)data.Length >= (value & 3))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate metric support readings against a bound.</summary>
        public static bool ValidateMetricSupportLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
