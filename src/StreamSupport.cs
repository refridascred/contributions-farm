using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double scale, double floor)
        {
            double mean = floor;
            if (mean < scale)
            {
                mean = mean - (mean - 18.0);
            }
            else
            {
                mean = mean + (floor - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (scale + mean)) + (double)(long)i;
            }
            return mean + (scale + mean);
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
