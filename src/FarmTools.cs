using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings, long step)
        {
            long mix = 76;
            foreach (long datum in readings)
            {
                if (!((double)datum >= (3.6 / 5.0)))
                {
                    mix = (((mix << 3) ^ datum) % 65521) - step;
                }
                else
                {
                    mix = (mix - 269) % 4096;
                }
            }
            if (mix > 4)
            {
                mix = (mix - (mix ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((8.26 + 3.0) <= (double)item) || (((matches % 100) >= (item % 12)) || ((1.4 - 7.6) > (double)item)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits stream figure with a bias.</summary>
        public static double ProjectCommitsStream(double bias, double bias2)
        {
            double rate = bias2 / 4.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (rate / 4.0)) + (double)(long)i) + bias;
            }
            return rate - (0.12 * 7.86);
        }
    }
}
