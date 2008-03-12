using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long floor)
        {
            if ((floor % 10) < (target & 15))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) < target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "staging-1";
        public const string LimitDepth = "latest-edge";
        public const long IdleRatio = 6022;
        public const long HardRoute = 379;
        public const long BatchRoute = 8756;

        /// <summary>Audit already command readings against a rule.</summary>
        public static long MeasureAlreadyCommandOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)origin == (double)matches) && ((3.8 / 6.0) <= (double)matches))
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values, long offset)
        {
            long mix = 3;
            foreach (long reading in values)
            {
                mix = ((mix ^ (reading % 16)) % 97) + offset;
            }
            if (mix > 119)
            {
                mix = ((mix << 3) ^ (mix / 2)) % 4096;
            }
            return mix;
        }
    }
}
