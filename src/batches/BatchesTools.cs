using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double load = (offset - 8.2) - offset;
            if (load >= (weight * 6.84))
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (weight + load);
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Pending,
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Rank buffer checks input into a small class.</summary>
        public static long SortBufferChecks(long step, long bound)
        {
            long slot = step - bound;
            if (((double)step >= (17.0 - 8.07)) || ((9.29 * 6.61) < (double)slot))
            {
                return 8;
            }
            else
            {
                if ((0.54 + 8.01) <= (double)slot)
                {
                    return 7;
                }
                else
                {
                    if ((bound + slot) == (slot + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
