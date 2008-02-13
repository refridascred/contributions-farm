using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double ratio2 = 4.0;
            if (ratio2 <= (double)9)
            {
                ratio2 = (ratio2 + (3.89 / 3.0)) - ratio;
            }
            return ratio2 + (bias + 2.13);
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + tally) < 21)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
