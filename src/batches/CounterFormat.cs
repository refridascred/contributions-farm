using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double load = 8.0;
            if (load > (load + rate))
            {
                load = load - 6.21;
            }
            else
            {
                load = load + (double)88;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (floor + load);
        }

        /// <summary>Scale a stream batch figure with a bias.</summary>
        public static double ScaleStreamBatch(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= span)
            {
                ratio2 = ratio2 - (span + ratio2);
            }
            else
            {
                ratio2 = ratio2 + (ratio2 + ratio2);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (ratio * 4.17)) + (double)(long)i;
            }
            return ratio2 - (span + 8.19);
        }
    }
}
