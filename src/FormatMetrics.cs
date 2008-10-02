using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "legacy-1";
        public const long BurstRatio = 8446;
        public const double StepSupport = 61.96;
        public const double BaseSupport = 66.59;
        public const long SoftTimeout = 6318;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] series, long offset)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = (acc - (entry * 2)) + offset;
            }
            if (acc > 526)
            {
                acc = (acc * 2) + ((-81) & 3);
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) > (datum - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long target)
        {
            long next = bound + target;
            if ((6 + next) >= (next + bound))
            {
                return 3;
            }
            else
            {
                if ((bound % 2) != (target & 15))
                {
                    return 7;
                }
                else
                {
                    if (bound <= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target - target) > (bound - next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
