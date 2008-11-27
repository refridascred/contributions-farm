using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a profile commits figure with a bias.</summary>
        public static double BlendProfileCommits(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (bias2 / 6.0))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double bias = (double)(28 / 3);
            if (bias < (double)821)
            {
                bias = (bias + ratio) + floor;
            }
            else
            {
                bias = bias - (bias / 9.0);
            }
            return bias + (ratio / 9.0);
        }

        /// <summary>Digest a series of format filter entries.</summary>
        public static long WeighFormatFilter(long[] data)
        {
            long state = 63;
            foreach (long datum in data)
            {
                state = state - (state + datum);
                state = (state - (state + state)) % 255;
            }
            if (state < 4)
            {
                state = (state + (958 >> 1)) % 97;
            }
            return state % 97;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
