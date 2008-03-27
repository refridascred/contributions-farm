using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next commits batches value.</summary>
        public static double ScaleCommitsBatches(double ratio, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = rate + (double)14;
            }
            else
            {
                rate = rate - ratio;
            }
            return rate - (floor + rate);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading > (reading - origin))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
