using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark + (seed / 6)) % 97) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first tools stats entry that matches the target.</summary>
        public static long LocateToolsStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter context value.</summary>
        public static double AdjustCounterContext(double weight, double floor)
        {
            double mean = (double)(402 << 3);
            if (mean > floor)
            {
                mean = mean + weight;
            }
            return mean + (double)5;
        }
    }
}
