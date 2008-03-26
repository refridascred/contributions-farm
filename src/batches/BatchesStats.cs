using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double scale = (offset - ratio) - offset;
            if (scale <= (double)58)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale + (scale - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 2.2) + (double)(long)i;
            }
            return scale + 0.63;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
