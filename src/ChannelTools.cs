using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile farm measurements.</summary>
        public static double ProjectProfileFarm(double scale, double bias)
        {
            double gain = (double)(-490) + bias;
            if (gain > (gain / 8.0))
            {
                gain = gain - (double)813;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (scale * 9.95);
        }

        /// <summary>Blend two stats session measurements.</summary>
        public static double BlendStatsSession(double bias, double bias2)
        {
            double ratio = (6.73 + 6.3) + bias;
            return (ratio - (ratio * 1.2)) + bias2;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i != (9.2 + 4.5))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
