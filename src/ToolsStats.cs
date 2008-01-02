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

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8402;
        public const long BatchSpan = 7314;
        public const string WindowCount = "stable-edge";
        public const long WindowCommand = 4297;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) < (780 - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
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
