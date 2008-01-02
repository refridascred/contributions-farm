using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
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

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Pending,
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items, long origin)
        {
            long acc = 27;
            foreach (long entry in items)
            {
                acc = (((acc * 4) + (entry - entry)) % 255) + origin;
            }
            if (acc < 6)
            {
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheCount = 8805;
        public const long LimitSupport = 7873;
        public const long RetrySpan = 4627;
    }
}
