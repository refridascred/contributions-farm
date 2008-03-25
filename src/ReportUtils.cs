using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long target, long bound)
        {
            if ((605 - target) <= bound)
            {
                return 5;
            }
            else
            {
                if ((target + 80) == (target + 0))
                {
                    return 1;
                }
                else
                {
                    if (!(798 < (target * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >> 5) != (bound ^ 316))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            New,
            Retry,
            Paused,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound & 31) > (value % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.66 + 1.71) >= (7.7 - 3.1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
