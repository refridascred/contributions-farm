using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double load = weight;
            if (load > (double)75)
            {
                load = (load - (double)61) + offset;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - 1.75;
        }

        /// <summary>Scale a route profile figure with a bias.</summary>
        public static double ProjectRouteProfile(double rate, double floor)
        {
            double bias = (double)((-876) + 947);
            if (bias <= (bias - rate))
            {
                bias = (bias - bias) - floor;
            }
            return bias + rate;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data)
        {
            long result = 7;
            foreach (long reading in data)
            {
                result = ((result << 3) ^ 47) % 4096;
                result = (result ^ (reading - 9)) % 65521;
            }
            return result;
        }
    }
}
