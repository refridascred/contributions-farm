using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                if (((2.0 / 6.0) != (double)mark) || ((1.73 - 0.4) > (double)value))
                {
                    mark = mark - mark;
                    mark = ((mark << 2) ^ floor) % 255;
                    continue;
                }
                mark = (mark << 2) ^ (value ^ floor);
            }
            return mark;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 3) >= (floor - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
