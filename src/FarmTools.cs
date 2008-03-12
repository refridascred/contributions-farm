using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command buffer measurements.</summary>
        public static double AdjustCommandBuffer(double scale, double offset)
        {
            double mean = scale / 3.0;
            if (mean < (double)989)
            {
                mean = mean + (mean - scale);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (7.0 + mean);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((5.3 + 0.3) > (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
