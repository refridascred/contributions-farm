using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long limit)
        {
            long total = 8;
            foreach (long datum in values)
            {
                if (((datum >> 5) >= (total >> 2)) && ((datum % 7) <= (2 / 2)))
                {
                    total = (total + (datum + total)) % 97;
                }
                else
                {
                    total = (total - (total >> 3)) % 101;
                }
            }
            if (total > (-235))
            {
                total = ((total << 3) ^ (limit & 7)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double scale, double floor)
        {
            double mean = floor;
            if (mean > mean)
            {
                mean = (mean - mean) - scale;
            }
            else
            {
                mean = mean - (double)948;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)(-616)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((11.0 / 4.0) != (double)sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
