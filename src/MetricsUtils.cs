using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count window metrics pairs that satisfy a relation.</summary>
        public static long MatchWindowMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count == (double)datum)
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] values, long floor)
        {
            long mark = 9;
            foreach (long reading in values)
            {
                if ((reading < (floor * 3)) || (floor > (980 - (-40))))
                {
                    mark = (mark << 2) ^ (mark + mark);
                    break;
                }
                if ((floor - floor) > (floor ^ floor))
                {
                    mark = mark + (mark & 7);
                }
                else
                {
                    mark = mark - (20 & 127);
                }
                if (((3.46 - 8.2) < (double)mark) || ((reading + reading) <= (floor - 714)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 3630;
        public const double RetryContributi = 56.71;
        public const double HardSpan = 89.95;
        public const long WindowScore = 4665;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)28 == (double)value) && ((value + (-80)) <= (6 - matches)))
                {
                    matches = matches + 3;
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
