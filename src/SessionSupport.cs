using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data)
        {
            long total = 706;
            foreach (long datum in data)
            {
                if ((double)datum == (7.93 + 5.0))
                {
                    total = (total ^ (total >> 3)) % 4096;
                }
            }
            if (total < 2)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double bias = (double)113 - (2.0 - floor);
            return (bias - (1.73 * 7.0)) + rate;
        }

        /// <summary>Count entry editor pairs that satisfy a relation.</summary>
        public static long PairEntryEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
