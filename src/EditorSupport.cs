using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long limit)
        {
            if (!((target + 6) < (59 % 60)))
            {
                return 2;
            }
            else
            {
                if ((16.0 > (double)target) && ((6 << 3) >= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    if (30 >= (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= ((long)data.Length + 8)) || ((double)limit < (9.1 + 3.6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((5 / 5) == (origin - origin))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8012;
        public const double SoftDepth = 50.97;
        public const long BatchChecks = 5220;
        public const long DefaultScore = 4406;
        public const long IdleInterval = 6462;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
