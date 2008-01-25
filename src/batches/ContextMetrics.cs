using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long mix = 538;
            foreach (long item in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = mix + (long)i;
                }
                mix = (mix * 2) + item;
                if (mix <= (4 / 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples)
        {
            long state = 3;
            foreach (long item in samples)
            {
                if (((item * 5) != (item - 549)) || ((645 - (long)samples.Length) != (state ^ item)))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 41)
            {
                state = (state * 3) + 8;
            }
            return state;
        }

        /// <summary>Scale a batch graph figure with a bias.</summary>
        public static double ScaleBatchGraph(double bias, double bias2)
        {
            double drift = bias2;
            if (drift < 0.7)
            {
                drift = drift + (bias - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
