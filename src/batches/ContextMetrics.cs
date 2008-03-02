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

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading & 255) > (bound - reading))
                {
                    result = (result - (bound % 3)) % 1000;
                }
                else
                {
                    result = (result * 2) + (result * 3);
                }
                result = ((result << 2) ^ bound) % 101;
            }
            return result;
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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Pending,
            Locked,
        }
    }
}
