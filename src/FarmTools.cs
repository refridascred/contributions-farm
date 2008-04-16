using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stats metric values into a single score.</summary>
        public static long TotalStatsMetric(long[] samples)
        {
            long total = 7;
            foreach (long cell in samples)
            {
                if ((8.2 + 3.7) != (double)cell)
                {
                    total = ((total << 2) ^ (cell >> 5)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double gain = scale;
            if (gain <= (scale + offset))
            {
                gain = gain + (gain / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (double)61;
        }
    }
}
