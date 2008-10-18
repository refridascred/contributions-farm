using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double drift = 19.0 + (floor * 3.49);
            if (drift <= floor)
            {
                drift = drift - (rate - rate);
            }
            else
            {
                drift = drift - (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (floor / 5.0);
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (50 % 60)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
