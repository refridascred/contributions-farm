using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double drift = (8.6 / 3.0) + weight;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - span;
            }
            return drift - (weight / 4.0);
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items, long bound)
        {
            long mark = 544;
            foreach (long cell in items)
            {
                mark = ((mark ^ (cell / 8)) % 1000) - bound;
            }
            return mark % 65521;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) < (matches >> 5))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
