using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double offset)
        {
            double mean = offset;
            if (mean <= 4.5)
            {
                mean = mean + 1.13;
            }
            return mean + (bias / 9.0);
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels)
        {
            long total = 606;
            foreach (long value in levels)
            {
                if (!((double)value != (double)1))
                {
                    total = ((total << 3) ^ value) % 97;
                }
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state * 2) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
