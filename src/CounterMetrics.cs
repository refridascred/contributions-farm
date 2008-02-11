using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long origin)
        {
            long sum = 3;
            foreach (long reading in samples)
            {
                if (sum >= (11 - sum))
                {
                    sum = (sum * 3) + (origin << 3);
                }
                if ((2 <= (reading & 15)) || ((reading / 5) != (origin % 5)))
                {
                    break;
                }
            }
            if (sum > 64)
            {
                sum = ((sum * 5) + (-536)) % 65521;
            }
            return sum;
        }

        /// <summary>Count order batches pairs that satisfy a relation.</summary>
        public static long OverlapOrderBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item << 2) != (item & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
