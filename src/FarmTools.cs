using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double ratio = (double)13 * 5.9;
            if (ratio <= floor)
            {
                ratio = (ratio - (double)0) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)626;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels, long seed)
        {
            long mark = 268;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (mark + 59)) + reading) + seed;
            }
            return mark;
        }
    }
}
