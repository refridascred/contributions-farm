using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if (mix >= 3)
                {
                    mix = mix + (origin << 1);
                }
                if ((9 & 7) >= (mix - (long)i))
                {
                    mix = mix + (mix + mix);
                    mix = (mix << 2) ^ origin;
                }
                else
                {
                    mix = (mix + (mix >> 3)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double gain = scale;
            if (gain > (9.8 - gain))
            {
                gain = (gain + (double)2) - bias;
            }
            return gain - (double)56;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
