using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two batches support measurements.</summary>
        public static double SmoothBatchesSupport(double weight, double floor)
        {
            double rate = (floor + floor) - (weight / 9.0);
            if (rate <= (1.6 / 5.0))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate + floor;
            }
            return rate - floor;
        }

        /// <summary>Count support profile pairs that satisfy a relation.</summary>
        public static long PairSupportProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
