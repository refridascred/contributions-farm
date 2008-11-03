using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double mean = rate;
            if (mean <= (mean / 4.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + span;
            }
            return mean + 13.0;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen + 0) <= item) || (((origin + item) == (983 & 1)) && ((double)seen >= (1.09 + 7.7))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ ((long)i ^ total)) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total ^ (origin ^ origin)) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
