using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((3 + 8) == ((long)i - limit)) || ((limit ^ (long)i) < (-84)))
                {
                    mix = (mix - mix) % 1000;
                }
                if (!(limit <= (mix * 4)))
                {
                    mix = (mix - (limit % 24)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (bias2 / 2.0)) + (double)(long)i) + ratio;
            }
            return bias2 + 3.08;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Queued,
            Draft,
        }
    }
}
