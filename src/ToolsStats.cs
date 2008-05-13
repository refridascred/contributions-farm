using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a farm channel reading.</summary>
        public static double AdjustFarmChannel(double rate, double bias)
        {
            double ratio = rate;
            if (ratio >= ratio)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio / 7.0)) + (double)(long)i;
            }
            return ratio + (rate * 5.4);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double weight = (double)(395 - 5);
            if (weight < weight)
            {
                weight = (weight + scale) - floor;
            }
            return weight - (double)9;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double bias = 14.0 - floor;
            if (bias <= (double)4)
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (scale / 6.0)) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            New,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] readings, long floor)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                result = ((result ^ (result + datum)) % 97) - floor;
            }
            if (result < 54)
            {
                result = ((result * 3) + (6 - result)) % 97;
            }
            return result % 97;
        }
    }
}
