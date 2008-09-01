using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long bound)
        {
            long anchor = -812;
            foreach (long sample in values)
            {
                anchor = ((anchor * 5) + (94 << 2)) % 255;
                anchor = (anchor << 3) ^ bound;
                if ((sample << 1) > 596)
                {
                    break;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor * 3) + (bound % 16);
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((floor % 3) > floor) && ((double)floor < (double)total))
                {
                    total = total - total;
                    total = (total ^ (floor >> 4)) % 1000;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
