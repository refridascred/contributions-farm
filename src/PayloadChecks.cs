using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)floor >= (4.0 - 4.1)) || (2 > (matches + 947)))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long origin)
        {
            long span = limit ^ origin;
            if ((limit - origin) == (origin << 2))
            {
                return 4;
            }
            else
            {
                if (((double)span > (2.47 - 9.3)) && ((span * 3) == (span + span)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + limit) != (origin + span))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit + limit) >= (limit >> 5)) && ((origin + 5) >= limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.9 / 2.0) > (double)item) || (matches > target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }
    }
}
