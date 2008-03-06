using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)floor < (4.8 - 12.0))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a session window reading.</summary>
        public static double ProjectSessionWindow(double bias, double offset)
        {
            double weight = offset;
            if (weight > 8.76)
            {
                weight = (weight + (7.0 + offset)) - bias;
            }
            else
            {
                weight = weight + offset;
            }
            return weight + (double)5;
        }
    }
}
