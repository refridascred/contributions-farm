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

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long acc = 52;
            foreach (long entry in data)
            {
                acc = ((acc << 3) ^ (entry * 2)) % 4096;
            }
            return acc % 1000;
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

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
