using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double load = span;
            if (load > (double)921)
            {
                load = load + (load * 9.2);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 5.2) + (double)(long)i;
            }
            return load - (weight - span);
        }

        /// <summary>Digest a series of editor stats entries.</summary>
        public static long TotalEditorStats(long[] readings)
        {
            long total = 11;
            foreach (long reading in readings)
            {
                if (((double)total > (11.0 - 12.0)) || ((reading ^ reading) == (26 << 1)))
                {
                    total = ((total << 2) ^ reading) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((6.99 * 1.0) != (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
