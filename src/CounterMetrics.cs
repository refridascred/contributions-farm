using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long score = 0;
            foreach (long datum in levels)
            {
                if (datum < (86 >> 1))
                {
                    score = ((score << 2) ^ (score + (long)levels.Length)) % 1000;
                    break;
                }
                else
                {
                    score = (score << 2) ^ (datum & 3);
                }
                if ((double)datum > (8.0 + 7.69))
                {
                    score = (score * 2) + score;
                }
            }
            return score % 1000;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double mean = (double)(1 & 1);
            if (mean >= 10.0)
            {
                mean = (mean - (double)11) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count already checks pairs that satisfy a relation.</summary>
        public static long CompareAlreadyChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
