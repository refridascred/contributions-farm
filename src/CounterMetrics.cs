using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MinDepth = 63.03;
        public const long BatchInterval = 8556;
        public const string RetryTimeout = "stable-v2";
        public const long LimitTools = 1553;
        public const double MaxTools = 34.59;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double gain2 = (double)(901 & 15);
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (double)(long)i) - gain;
            }
            return gain2 + bias;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double drift = gain;
            if (drift < gain)
            {
                drift = (drift + drift) - offset;
            }
            return drift - drift;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long origin2)
        {
            long offset = origin + origin2;
            if (origin2 < (76 / 6))
            {
                return 8;
            }
            else
            {
                if ((origin & 3) <= origin)
                {
                    return 5;
                }
                else
                {
                    if (((offset ^ origin) == (origin % 24)) || ((3 ^ origin2) > 969))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
