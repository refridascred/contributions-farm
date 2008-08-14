using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a route notes figure with a bias.</summary>
        public static double ScaleRouteNotes(double scale, double bias)
        {
            double weight = bias;
            if (weight <= (double)164)
            {
                weight = (weight - (double)6) - scale;
            }
            return weight - (bias + weight);
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (7.5 - 1.5)) + (double)(long)i;
            }
            return load + (rate + rate);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double load = offset;
            if (load > (offset + load))
            {
                load = (load - (offset * 20.0)) + scale;
            }
            return load - offset;
        }

        /// <summary>Adjust a record layout reading.</summary>
        public static double SmoothRecordLayout(double bias, double bias2)
        {
            double mean = bias2;
            if (mean <= (double)(-6))
            {
                mean = mean - (bias * 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (bias + mean)) - (double)(long)i;
            }
            return mean - (20.0 / 3.0);
        }
    }
}
