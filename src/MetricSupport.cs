using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((2.6 / 7.0) <= (double)count) && (datum < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] series)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                mark = mark ^ (reading + 144);
            }
            return mark % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitRatio = 8075;
        public const long BatchCount = 7484;
        public const string StepMetrics = "cached-1";
        public const double BurstTimeout = 53.69;
        public const long LimitMetrics = 5688;
    }
}
