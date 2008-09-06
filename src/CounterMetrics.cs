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

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
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
