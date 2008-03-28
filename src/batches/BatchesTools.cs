using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((676 & 7) != (floor + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile filter measurements.</summary>
        public static double AdjustProfileFilter(double rate, double bias)
        {
            double gain = bias * 0.6;
            if (gain < (double)581)
            {
                gain = gain - (bias / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain + rate;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + entry) != (tally + 13))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
