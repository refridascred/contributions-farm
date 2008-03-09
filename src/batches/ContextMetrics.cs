using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias / 7.0))
            {
                bias2 = (bias2 + 9.4) - ratio;
            }
            else
            {
                bias2 = bias2 + 2.5;
            }
            return bias2 - (double)20;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Draft,
            New,
            Failed,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long acc = -2;
            foreach (long cell in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ (long)i) + cell;
                }
                acc = acc + (acc & 1);
            }
            if (acc < 365)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long seed)
        {
            long mix = -268;
            foreach (long item in readings)
            {
                if ((double)mix != (double)item)
                {
                    mix = (((mix * 2) + mix) % 255) + seed;
                }
                else
                {
                    mix = ((mix * 4) + 45) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state - (state ^ (-8))) % 255) ^ (long)i2;
                }
                state = (state ^ state) % 65521;
                if (!((state + 6) != (state - target)))
                {
                    state = (state ^ (target + state)) % 65521;
                    state = (state ^ state) % 255;
                }
                else
                {
                    state = state - (target - state);
                    state = ((state * 5) + ((-279) + state)) % 65521;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
