using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 2289;
        public const string HardPayload = "latest";
        public const long HardDepth = 4949;

        /// <summary>Adjust a metrics profile reading.</summary>
        public static double BlendMetricsProfile(double scale, double bias)
        {
            double load = bias;
            if (load < (bias + 8.78))
            {
                load = load - scale;
            }
            else
            {
                load = load + (bias + 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load - load)) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Locate a route profile reading by value.</summary>
        public static long LocateRouteProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
