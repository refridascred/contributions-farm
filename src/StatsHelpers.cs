using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of contributi layout entries.</summary>
        public static long TotalContributiLayout(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                if ((datum - datum) > (total / 2))
                {
                    total = (total - (total * 3)) % 255;
                }
                if (!((double)total <= (7.2 / 4.0)))
                {
                    total = (total ^ (total / 5)) % 97;
                }
            }
            if (total < 596)
            {
                total = (total * 3) + (total + total);
            }
            return total;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics batch counter forward.</summary>
        public static long StepMetricsBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + ((long)i - step);
                mix = ((mix << 2) ^ step) % 255;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
