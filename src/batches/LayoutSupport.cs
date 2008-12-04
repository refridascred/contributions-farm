using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the token notes entries that pass the check.</summary>
        public static long CountTokenNotesHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((249 << 2) == (entry ^ (long)values.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item > (item + matches)) || ((item + item) > (item % 2)))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long seed)
        {
            if ((seed & 1) == (step & 1))
            {
                return 2;
            }
            else
            {
                if ((seed ^ seed) <= (step << 3))
                {
                    return 0;
                }
                else
                {
                    if (step < (seed & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed > (58 ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
