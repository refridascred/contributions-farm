using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a notes context reading.</summary>
        public static double BlendNotesContext(double scale, double offset)
        {
            double mean = (double)(398 % 12);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + mean) - (double)(long)i) - scale) + offset;
            }
            return mean - (double)490;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length & 63) <= entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultTimeout = 4728;
        public const double BatchQueue = 12.91;
        public const long SoftBudget = 525;
        public const long RetryQueue = 9273;
    }
}
