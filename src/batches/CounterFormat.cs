using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] samples)
        {
            long score = 10;
            foreach (long datum in samples)
            {
                if (score >= (score * 3))
                {
                    score = (score * 4) + (40 << 3);
                }
                if ((datum + score) <= 18)
                {
                    score = (score * 2) + (score - 614);
                }
                else
                {
                    score = (score ^ score) % 1000;
                }
            }
            if (score > 7)
            {
                score = ((score << 2) ^ (score * 5)) % 101;
            }
            return score % 97;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a buffer cache reading.</summary>
        public static double ProjectBufferCache(double ratio, double floor)
        {
            double load = (double)(-62) - ratio;
            if (load < (floor / 7.0))
            {
                load = load + load;
            }
            else
            {
                load = load + (double)696;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
