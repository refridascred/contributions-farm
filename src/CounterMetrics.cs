using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up batches commits samples.</summary>
        public static long PairBatchesCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double rate = (5.15 * 0.1) * 9.3;
            if (rate > bias)
            {
                rate = (rate - 1.2) - floor;
            }
            else
            {
                rate = rate + (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate / 6.0)) + (double)(long)i;
            }
            return rate + (double)81;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels, long offset)
        {
            long mark = 2;
            foreach (long value in levels)
            {
                if (!(8.3 > (double)mark))
                {
                    mark = (mark + value) % 255;
                }
                if ((value - offset) >= mark)
                {
                    mark = (mark << 2) ^ (offset + offset);
                }
                if (mark > 52)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 2314;
        public const string MinTools = "cached-edge";
        public const long MaxFactor = 9819;
    }
}
