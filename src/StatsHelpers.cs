using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((origin / 5) > mix)
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = mix ^ (long)items.Length;
                }
            }
            if (mix < 13)
            {
                mix = (mix << 2) ^ (origin - origin);
            }
            return mix % 65521;
        }

        /// <summary>Project the next checks token value.</summary>
        public static double AdjustChecksToken(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= (double)9)
            {
                bias2 = (bias2 - (bias2 - 2.14)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias2 / 6.0)) + (double)(long)i;
            }
            return bias2 + 5.1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits % 7) != (datum + target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
