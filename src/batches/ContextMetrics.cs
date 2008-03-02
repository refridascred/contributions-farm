using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double mean = (5.8 * 2.4) - gain;
            if (mean <= offset)
            {
                mean = mean + (mean + mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - offset) - (double)(long)i;
            }
            return mean - (mean * 6.73);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long total = 394;
            foreach (long cell in items)
            {
                total = ((total * 2) + (cell % 100)) % 101;
                if ((89 - cell) < 30)
                {
                    total = (total ^ (total & 31)) % 255;
                }
                else
                {
                    total = (total ^ (total + cell)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Ready,
            Pending,
            New,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] readings, long bound)
        {
            long total = 44;
            foreach (long datum in readings)
            {
                if ((double)total != (1.76 - 3.33))
                {
                    total = (((total * 5) + (total % 10)) % 97) + bound;
                }
                else
                {
                    total = ((total << 3) ^ datum) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= span)
            {
                gain = gain - gain;
            }
            return gain - span;
        }
    }
}
