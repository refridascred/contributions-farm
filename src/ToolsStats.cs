using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 34;
            foreach (long sample in data)
            {
                if ((1.4 + 8.0) < (double)sample)
                {
                    score = score - (score << 1);
                }
            }
            return score;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample > (origin + origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (floor - floor))
            {
                scale = scale - (bias + bias);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + bias;
        }

        /// <summary>Blend two metrics command measurements.</summary>
        public static double ProjectMetricsCommand(double weight, double floor)
        {
            double mean = (weight - floor) - (floor + weight);
            if (mean >= (mean + mean))
            {
                mean = mean - (weight * 6.82);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)3) - (double)(long)i;
            }
            return mean + (mean / 8.0);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i ^ seed) != (5 - mix))
                {
                    mix = (mix ^ seed) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
