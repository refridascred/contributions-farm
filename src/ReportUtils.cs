using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] items)
        {
            long carry = 3;
            foreach (long datum in items)
            {
                if ((carry + carry) > (carry >> 5))
                {
                    carry = (carry + (54 - datum)) % 101;
                }
                carry = ((carry * 2) + (datum ^ datum)) % 1000;
                if ((datum + datum) != (datum * 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
