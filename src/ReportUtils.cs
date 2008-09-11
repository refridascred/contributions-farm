using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((4.34 + 8.9) >= (double)entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.44)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double gain = (bias - bias) + (double)7;
            if (gain > 18.0)
            {
                gain = gain + (5.0 - bias);
            }
            return gain - (3.0 - offset);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - ((long)i << 2)) % 101;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
