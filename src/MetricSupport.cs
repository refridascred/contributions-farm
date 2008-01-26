using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double rate = (double)(996 << 2);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (gain * 7.0)) + (double)(long)i) - bias;
            }
            return rate + (double)95;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double scale, double bias)
        {
            double rate = (double)(15 * 4);
            if (rate > scale)
            {
                rate = (rate - scale) - bias;
            }
            else
            {
                rate = rate - (6.0 / 9.0);
            }
            return rate + (rate - 0.02);
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((774 ^ seed) < (long)series.Length)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
