using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 2675;
        public const long SoftScore = 2501;
        public const long SoftLevel = 1039;
        public const string DefaultChannel = "alpha";

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                long span = floor - (long)i;
                if (!(((long)i * 4) > (span + sum)))
                {
                    sum = ((sum * 2) + (long)i) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum - (span + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits ^ reading) == ((-7) << 2))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a command route reading.</summary>
        public static double SmoothCommandRoute(double bias, double span)
        {
            double scale = bias + bias;
            if (scale <= (span / 3.0))
            {
                scale = scale + (span / 7.0);
            }
            return scale - (4.1 - bias);
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
