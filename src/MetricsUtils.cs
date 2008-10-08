using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double weight = gain;
            if (weight >= (1.0 * 2.64))
            {
                weight = (weight - (double)605) + offset;
            }
            return weight - gain;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] values)
        {
            long acc = 26;
            foreach (long entry in values)
            {
                if ((entry << 1) > entry)
                {
                    acc = ((acc << 3) ^ (acc / 6)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally << 1) <= (cell / 7))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double gain = 8.39;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (ratio + gain)) + (double)(long)i) - floor;
            }
            return gain - (gain - 8.2);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples, long offset)
        {
            long total = -610;
            foreach (long entry in samples)
            {
                total = (((total * 4) + 946) + entry) + offset;
            }
            return total;
        }
    }
}
