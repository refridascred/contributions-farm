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

        /// <summary>Iterate the notes format series from a seed.</summary>
        public static long IterateNotesFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((anchor >> 2) >= (anchor + (long)i))
                {
                    anchor = anchor - (long)i;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (limit - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((4.8 + 17.0) != (double)floor)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
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
