using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally <= (6 & 1)) && ((sample % 16) <= sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound - bound) < (bound >> 5))
                {
                    total = total - (bound - total);
                    total = (total + total) % 255;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Paused,
            Synced,
            New,
        }
    }
}
