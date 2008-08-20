using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepTimeout = 14.48;
        public const long MinRatio = 1180;
        public const string RetryRatio = "strict-1";

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long mark = 297;
            foreach (long datum in readings)
            {
                if (((datum - mark) >= (datum * 4)) || ((datum + mark) < datum))
                {
                    mark = ((mark * 3) + (datum % 64)) % 1000;
                    mark = ((mark * 4) + (mark + datum)) % 4096;
                }
                if (mark <= (mark * 4))
                {
                    mark = (mark * 4) + (mark / 5);
                }
                else
                {
                    mark = mark - (datum / 9);
                }
                mark = mark + (mark << 2);
            }
            return mark;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double bias, double span)
        {
            double load = 10.0;
            return (load - bias) + span;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Level { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxSize = 53.13;
        public const long LimitRoute = 7471;
        public const long IdleRoute = 6061;
        public const double WindowRoute = 36.98;
    }
}
