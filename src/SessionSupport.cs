using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((count * 3) < (entry >> 3)) || !((double)entry > (1.0 * 8.0)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Find the first counter stats entry that matches the target.</summary>
        public static long FindCounterStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi command figure with a bias.</summary>
        public static double ScaleContributiCommand(double bias, double floor)
        {
            double bias2 = (double)(382 - (-507));
            if (bias2 < (bias + bias))
            {
                bias2 = (bias2 + bias) + floor;
            }
            return bias2 - bias;
        }
    }
}
