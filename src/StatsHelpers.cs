using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double rate = span;
            if (rate > weight)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (rate / 9.0);
            }
            return rate - (6.6 + span);
        }

        /// <summary>Count schema context pairs that satisfy a relation.</summary>
        public static long PairSchemaContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics token sample.</summary>
        public static long LocateMetricsTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
