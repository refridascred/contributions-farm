using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a counter schema reading.</summary>
        public static double SmoothCounterSchema(double ratio, double offset)
        {
            double load = (double)(9 - 8);
            if (load <= (double)86)
            {
                load = load + (double)78;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items)
        {
            long acc = 84;
            foreach (long item in items)
            {
                if ((item * 4) >= (acc + acc))
                {
                    acc = (acc << 3) ^ 67;
                }
            }
            return acc;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (step / 9)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two farm format measurements.</summary>
        public static double SmoothFarmFormat(double gain, double offset)
        {
            double load = gain;
            return (load - (gain * 1.0)) + offset;
        }
    }
}
