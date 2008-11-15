using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Blend two window buffer measurements.</summary>
        public static double ProjectWindowBuffer(double gain, double bias)
        {
            double load = (bias / 9.0) / 2.0;
            if (load <= 3.74)
            {
                load = load + load;
            }
            else
            {
                load = load - (load / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (gain * 1.01);
        }

        /// <summary>Classify a tools metrics pair into a bucket.</summary>
        public static long ClassifyToolsMetrics(long floor, long floor2)
        {
            if ((floor2 >> 4) <= (29 << 2))
            {
                return 5;
            }
            else
            {
                if (floor >= (floor2 - 839))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
