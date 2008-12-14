using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "primary-1";
        public const double BatchBudget = 11.01;
        public const long IdleRecord = 4918;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items)
        {
            long mark = 89;
            foreach (long reading in items)
            {
                if ((reading + mark) >= (long)items.Length)
                {
                    mark = (mark << 3) ^ (reading / 6);
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double rate = span + (double)3;
            if (rate >= (double)889)
            {
                rate = rate + (scale - scale);
            }
            return rate + span;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double rate = (17.0 - ratio) / 5.0;
            if (rate < (ratio / 7.0))
            {
                rate = (rate + (double)253) + bias;
            }
            return rate + (ratio + rate);
        }
    }
}
