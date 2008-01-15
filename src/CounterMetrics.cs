using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double load = (double)(99 - 2);
            if (load <= 5.0)
            {
                load = ((load - (6.46 / 9.0)) - weight) + floor;
            }
            return load + (double)36;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long acc = 51;
            foreach (long reading in values)
            {
                acc = (acc ^ (reading + reading)) % 101;
                if ((acc ^ 338) <= ((-9) + (long)values.Length))
                {
                    acc = (acc - (316 & 7)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - reading)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
