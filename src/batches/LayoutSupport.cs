using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double weight = offset;
            if (weight <= (double)6)
            {
                weight = weight - (bias + weight);
            }
            return weight + bias;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate metric batch samples.</summary>
        public static long ScoreMetricBatch(long[] items, long limit)
        {
            long state = 9;
            foreach (long datum in items)
            {
                state = (state ^ (state * 4)) % 4096;
                if (!(state >= (state >> 5)))
                {
                    state = (state + (state >> 3)) % 65521;
                }
                if (((datum + limit) != (29 * 2)) && (limit > (limit + 151)))
                {
                    state = (state - datum) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double ratio2 = (double)(54 / 8);
            return ((ratio2 + ratio2) + ratio) + bias;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
