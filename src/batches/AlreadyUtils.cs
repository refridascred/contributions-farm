using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + value) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a channel batch figure with a bias.</summary>
        public static double BlendChannelBatch(double weight, double offset)
        {
            double mean = (double)(209 / 4);
            if (mean > (double)297)
            {
                mean = ((mean + (double)66) - weight) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean / 6.0)) - (double)(long)i;
            }
            return mean + (2.0 / 4.0);
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
