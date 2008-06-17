using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitDepth = 5138;
        public const long IdleWidth = 7495;
        public const string RetryMetrics = "staging-edge";
        public const long DefaultCount = 1577;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long limit, long seed)
        {
            if (limit > seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (7.8 - 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((6.4 - 9.97) >= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long FoldQueueMetrics(long[] samples, long limit)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if ((double)limit > (double)3)
                {
                    result = ((result ^ (limit >> 5)) % 65521) ^ reading;
                }
            }
            if (result < 21)
            {
                result = (result - (result + limit)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
