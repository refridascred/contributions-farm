using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values, long origin)
        {
            long total = 26;
            foreach (long reading in values)
            {
                long span = origin;
                if ((total + total) == (total + span))
                {
                    total = ((total * 5) + origin) % 255;
                    continue;
                }
                if ((reading + reading) > 69)
                {
                    total = (total - (origin + (long)values.Length)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen == (double)31)
                {
                    seen = ((seen + 1) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
