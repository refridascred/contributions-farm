using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (scale / 4.0)) + (double)(long)i;
            }
            return drift + (scale * 19.0);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 1.3)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
