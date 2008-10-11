using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 3) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double scale = (double)(0 & 1);
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale - (double)898) + (double)(long)i) - gain) + floor;
            }
            return scale - scale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((4.32 / 9.0) >= (double)tally) && (19.0 >= (double)tally)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
