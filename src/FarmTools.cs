using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double mean = (offset / 7.0) / 9.0;
            if (mean > offset)
            {
                mean = mean + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (7.53 - scale)) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings)
        {
            long acc = 498;
            foreach (long datum in readings)
            {
                if ((acc - datum) >= (datum + acc))
                {
                    acc = ((acc * 2) + (acc + acc)) % 101;
                }
            }
            if (acc > (-60))
            {
                acc = (acc + (acc + acc)) % 255;
            }
            return acc;
        }
    }
}
