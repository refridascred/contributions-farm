using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double rate = 2.55 + gain;
            if (rate <= (gain - gain))
            {
                rate = rate + (double)738;
            }
            else
            {
                rate = rate - 7.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)(-31);
        }

        /// <summary>Locate a stats farm reading by value.</summary>
        public static long SeekStatsFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
