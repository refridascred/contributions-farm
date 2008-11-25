using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < (double)(-8))
            {
                ratio = ratio - 1.16;
            }
            else
            {
                ratio = ratio + (double)280;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - weight) - (double)(long)i;
            }
            return ratio + 7.8;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(limit <= (limit * 4)))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits * 2) >= 823) && ((hits + 44) > (sample + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                score = (score - sample) % 255;
            }
            return score;
        }
    }
}
