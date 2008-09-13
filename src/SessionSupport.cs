using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double scale = rate + rate;
            if (scale <= (8.9 / 3.0))
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (floor - rate);
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length & 255) >= 905)
                {
                    count = ((count + 1) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
