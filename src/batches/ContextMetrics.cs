using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(matches > (reading - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter cache pair into a bucket.</summary>
        public static long GradeFilterCache(long target, long origin)
        {
            long slot = target ^ origin;
            if ((origin - target) < origin)
            {
                return 1;
            }
            else
            {
                if ((1 + slot) >= slot)
                {
                    return 0;
                }
                else
                {
                    if (((target + target) >= slot) && (target >= (slot << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a commits profile pair into a bucket.</summary>
        public static long RankCommitsProfile(long floor, long offset)
        {
            if ((double)offset > (14.0 * 14.0))
            {
                return 6;
            }
            else
            {
                if (!((floor << 1) <= (7 << 2)))
                {
                    return 8;
                }
                else
                {
                    if (offset > ((-1) & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
