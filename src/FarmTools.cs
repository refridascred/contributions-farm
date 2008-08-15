using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series, long seed)
        {
            long anchor = 43;
            foreach (long reading in series)
            {
                if (((anchor - anchor) <= (8 + anchor)) && ((double)reading <= (9.8 + 0.53)))
                {
                    anchor = ((anchor ^ reading) % 65521) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double scale = floor;
            if (scale >= (gain - floor))
            {
                scale = scale + gain;
            }
            return scale + (double)9;
        }
    }
}
