using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double drift = (double)(1 + 88);
            if (drift < (bias2 * 1.46))
            {
                drift = drift - (bias2 - bias2);
            }
            else
            {
                drift = drift + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias + bias)) + (double)(long)i;
            }
            return drift - bias2;
        }

        /// <summary>Blend two cache command measurements.</summary>
        public static double SmoothCacheCommand(double weight, double offset)
        {
            double rate = 4.94;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate - offset;
        }
    }
}
