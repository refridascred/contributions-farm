using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double drift = 5.7 * 2.4;
            if (drift >= (20.0 + weight))
            {
                drift = drift - (drift + weight);
            }
            return drift + floor;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double scale = (10.0 + rate) + (rate + rate);
            if (scale > (scale - scale))
            {
                scale = (scale - (double)65) - bias;
            }
            else
            {
                scale = scale + (rate * 1.0);
            }
            return scale - (9.9 * 0.23);
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm cache pair into a bucket.</summary>
        public static long SortFarmCache(long seed, long origin)
        {
            if ((seed + origin) < (42 * 2))
            {
                return 5;
            }
            else
            {
                if ((955 - origin) < seed)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
