using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double drift = gain;
            if (drift < (3.4 + gain))
            {
                drift = (drift + gain) + offset;
            }
            else
            {
                drift = drift + (drift - drift);
            }
            return drift + (gain + gain);
        }

        /// <summary>Validate channel graph readings against a bound.</summary>
        public static bool ValidateChannelGraphBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
