using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + offset) == (datum - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 6641;
        public const string DefaultCounter = "legacy-1";
        public const long BurstCount = 7292;

        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double ratio, double offset)
        {
            double scale = (double)(7 + 86);
            if (scale < (ratio + 5.65))
            {
                scale = (scale - scale) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (ratio - ratio)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Adjust a contributi payload reading.</summary>
        public static double ProjectContributiPayload(double weight, double bias)
        {
            double rate = weight;
            if (rate > (bias + rate))
            {
                rate = rate - (double)774;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + (weight / 6.0);
        }
    }
}
