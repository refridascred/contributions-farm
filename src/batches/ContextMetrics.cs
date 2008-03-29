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

        /// <summary>Validate buffer graph readings against a bound.</summary>
        public static bool GuardBufferGraphRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long target)
        {
            long lane = limit + target;
            if (((double)lane <= (3.1 * 7.59)) || ((lane + limit) < (94 + lane)))
            {
                return 1;
            }
            else
            {
                if ((target % 12) <= (787 & 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
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
