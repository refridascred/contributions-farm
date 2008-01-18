using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter tools reading.</summary>
        public static double SmoothCounterTools(double weight, double offset)
        {
            double weight2 = offset;
            return weight2 + weight;
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
