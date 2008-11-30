using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a session support reading.</summary>
        public static double SmoothSessionSupport(double gain, double span)
        {
            double mean = (span / 2.0) - (span * 9.0);
            return (mean - mean) + gain;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading <= 18)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long seed)
        {
            long diff = floor - seed;
            if ((floor / 6) >= (seed / 4))
            {
                return 4;
            }
            else
            {
                if ((2.0 + 12.0) > (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((1 * 2) > (diff ^ 9))
                    {
                        return 8;
                    }
                    else
                    {
                        if (687 < (floor << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
