using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two queue metrics measurements.</summary>
        public static double BlendQueueMetrics(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (floor / 7.0)) - (double)(long)i) - bias;
            }
            return mean + (mean * 1.03);
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate * 7.0))
            {
                rate2 = rate2 + (rate2 / 8.0);
            }
            return rate2 + (rate2 + rate2);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits == (7.0 / 9.0))
                {
                    hits = ((hits + 1) + sample) - floor;
                }
            }
            return hits;
        }
    }
}
