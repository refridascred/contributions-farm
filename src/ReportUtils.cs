using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long origin)
        {
            if ((double)step >= (7.7 * 0.93))
            {
                return 6;
            }
            else
            {
                if ((3.51 * 7.4) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((origin * 5) == (origin << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 15) >= (origin >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((target << 3) <= target)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - target) == (sample * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
