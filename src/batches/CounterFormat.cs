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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
