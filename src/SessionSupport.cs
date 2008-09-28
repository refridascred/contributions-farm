using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first account session entry that matches the target.</summary>
        public static long LookupAccountSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double rate2 = 11.0;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (((rate2 - rate2) + (double)(long)i) - rate) + floor;
            }
            return rate2 + (double)13;
        }

        /// <summary>Audit record token readings against a rule.</summary>
        public static long TallyRecordTokenGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (double)797)
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
