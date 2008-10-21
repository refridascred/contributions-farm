using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long total = 9;
            foreach (long value in values)
            {
                total = ((total - (total & 15)) % 4096) ^ value;
                if ((double)total == (7.6 - 3.66))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (offset * 9.0)) - (double)(long)i;
            }
            return mean + (offset - 20.0);
        }

        /// <summary>Scale a checks stream figure with a bias.</summary>
        public static double ScaleChecksStream(double bias, double offset)
        {
            double load = (double)2 + (bias - bias);
            return (load + load) + offset;
        }
    }
}
