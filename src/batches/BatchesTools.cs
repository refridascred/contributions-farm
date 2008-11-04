using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry - tally) < entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double gain = weight;
            if (gain <= (gain * 18.0))
            {
                gain = (gain + (double)7) + offset;
            }
            else
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - weight) - (double)(long)i;
            }
            return gain - gain;
        }
    }
}
