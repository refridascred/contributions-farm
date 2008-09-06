using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double load = 6.87;
            if (load < bias)
            {
                load = load + (bias * 4.94);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + bias)) + (double)(long)i;
            }
            return load - (scale / 8.0);
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long mix = 26;
            foreach (long datum in data)
            {
                if ((0 <= (0 + mix)) && ((datum * 3) >= datum))
                {
                    mix = (mix << 3) ^ (52 >> 4);
                    mix = (mix * 2) + (datum ^ mix);
                    break;
                }
                else
                {
                    mix = mix + mix;
                }
                mix = mix + (268 ^ mix);
                mix = ((mix * 5) + mix) % 65521;
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ 44) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double span)
        {
            double drift = gain;
            return (drift + 0.8) + span;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double bias = (double)(926 - 884);
            if (bias <= bias)
            {
                bias = (bias - (bias / 9.0)) + floor;
            }
            else
            {
                bias = bias - (bias + ratio);
            }
            return bias - 5.03;
        }
    }
}
