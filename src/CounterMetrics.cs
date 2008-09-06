using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double floor)
        {
            double load = 8.1;
            if (load >= (double)(-309))
            {
                load = load - floor;
            }
            else
            {
                load = load - load;
            }
            return load - gain;
        }

        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double ProjectStatsLayout(double rate, double floor)
        {
            double drift = (double)(9 - (-1));
            if (drift < (double)728)
            {
                drift = (drift - (drift / 3.0)) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift - drift)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double bias = scale;
            return bias + (floor + scale);
        }
    }
}
