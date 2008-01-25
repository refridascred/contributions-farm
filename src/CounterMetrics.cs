using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long bound, long floor)
        {
            if (floor <= (bound - 93))
            {
                return 3;
            }
            else
            {
                if ((floor + bound) != (floor - floor))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double bias, double floor)
        {
            double ratio = (bias + 1.64) + (double)84;
            if (ratio >= (20.0 + bias))
            {
                ratio = (ratio - (ratio * 9.22)) + floor;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + 7.2;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Active,
            Dropped,
            Idle,
        }
    }
}
