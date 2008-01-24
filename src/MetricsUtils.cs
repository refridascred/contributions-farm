using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a format account pair into a bucket.</summary>
        public static long ClassifyFormatAccount(long limit, long floor)
        {
            if ((245 - limit) < limit)
            {
                return 1;
            }
            else
            {
                if (279 < (limit % 16))
                {
                    return 3;
                }
                else
                {
                    if (((6 + limit) > (floor % 64)) || ((floor - floor) != (limit + floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor > (20.0 / 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series, long bound)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                if ((221 - datum) > (datum + (-95)))
                {
                    carry = ((carry * 2) + carry) - bound;
                }
            }
            return carry;
        }
    }
}
