using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order graph series from a seed.</summary>
        public static long StepOrderGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (mix + seed)) % 97;
                mix = (mix * 3) + (mix * 4);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long step)
        {
            long mark = 867;
            foreach (long entry in readings)
            {
                mark = (mark << 3) ^ (step * 4);
                mark = (mark - (entry ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next support command value.</summary>
        public static double SmoothSupportCommand(double rate, double bias)
        {
            double scale = bias;
            if (scale < (double)(-5))
            {
                scale = (scale + scale) - rate;
            }
            else
            {
                scale = scale - (double)531;
            }
            return scale - (bias * 4.0);
        }
    }
}
