using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long seed)
        {
            if ((double)target == (1.6 * 13.0))
            {
                return 4;
            }
            else
            {
                if ((6 + target) >= target)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + 364) == (entry + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long offset)
        {
            long step = bound - offset;
            if (bound >= (step >> 3))
            {
                return 6;
            }
            else
            {
                if (((7.0 + 5.0) < (double)step) || (8.86 >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) >= (step - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (1.21 < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
