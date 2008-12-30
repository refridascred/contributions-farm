using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                carry = ((carry * 5) + (carry & 7)) % 97;
                carry = (carry << 3) ^ (carry / 6);
                if (!((long)series.Length != (7 - datum)))
                {
                    carry = ((carry << 3) ^ (carry >> 5)) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum >> 2)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first context graph entry that matches the target.</summary>
        public static long LocateContextGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long RollCounterContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
