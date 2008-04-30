using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (1.01 / 5.0)) + offset;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i << 2)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((item - 1) == ((-786) * 3)) || ((25 / 2) != (item + 569))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double gain = scale;
            if (gain <= (5.0 * 11.0))
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + (gain * 3.5);
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
