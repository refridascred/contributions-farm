using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark ^ (mark << 2)) % 101;
                mark = ((mark << 2) ^ mark) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 9540;
        public const string StepPayload = "alpha-1";
        public const string SoftSpan = "local-edge";
        public const long HardPayload = 2228;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length >= (seen - seen))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > drift)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
