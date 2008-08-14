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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state << 3) ^ state) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
