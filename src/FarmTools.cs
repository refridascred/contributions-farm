using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((limit + limit) >= (count + sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double drift = (span * 11.0) / 7.0;
            if (drift <= (double)5)
            {
                drift = (drift + 12.0) + gain;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - 9.1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double rate2 = 6.4 * 4.78;
            return ((rate2 + (double)714) + rate) + offset;
        }
    }
}
