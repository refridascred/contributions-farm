using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Pending,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double ratio2 = floor - (ratio - floor);
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - (double)0;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = state - (sample ^ limit);
                state = (state << 3) ^ state;
                if ((sample ^ sample) < state)
                {
                    state = (state - (17 + state)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples, long origin)
        {
            long acc = 565;
            foreach (long reading in samples)
            {
                if ((origin & 31) <= origin)
                {
                    acc = acc - (acc << 3);
                    acc = ((acc * 3) + reading) % 97;
                }
                acc = acc - (reading >> 4);
            }
            if (acc < 55)
            {
                acc = (acc - (9 - origin)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double load = bias;
            if (load <= (double)70)
            {
                load = (load + (load * 20.0)) + rate;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)3) - (double)(long)i;
            }
            return load - load;
        }
    }
}
