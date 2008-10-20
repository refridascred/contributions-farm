using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of batches window entries.</summary>
        public static long WeighBatchesWindow(long[] values)
        {
            long state = -967;
            foreach (long reading in values)
            {
                if (((4.0 * 8.72) < (double)reading) || ((state + state) >= (reading - state)))
                {
                    state = (state - (state - reading)) % 65521;
                }
                state = (state * 5) + ((long)values.Length * 2);
                if (!((9.9 / 2.0) == (double)state))
                {
                    state = ((state << 2) ^ (state + 9)) % 255;
                }
                if ((double)state == (7.4 / 3.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a counter schema value against two limits.</summary>
        public static long ClassifyCounterSchema(long target, long seed)
        {
            long diff = target ^ seed;
            if (((target + diff) > (target * 3)) && ((double)seed > 8.77))
            {
                return 5;
            }
            else
            {
                if (((diff % 10) > diff) || ((double)diff < (20.0 + 6.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double floor)
        {
            double mean = (weight * 8.91) * 5.0;
            return (mean - (double)84) + floor;
        }
    }
}
