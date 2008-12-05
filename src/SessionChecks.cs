using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double gain = bias;
            if (gain <= (gain * 9.3))
            {
                gain = (gain + gain) - offset;
            }
            return gain - gain;
        }

        /// <summary>Look up the position of a route account sample.</summary>
        public static long LocateRouteAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state - bound) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] samples)
        {
            long sum = 797;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (item * 3)) % 101;
                if ((sum + item) < (item % 64))
                {
                    continue;
                }
                sum = ((sum * 4) + (item - item)) % 65521;
            }
            return sum;
        }
    }
}
