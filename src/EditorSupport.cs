using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long bound)
        {
            if ((bound / 6) == (65 & 1))
            {
                return 3;
            }
            else
            {
                if ((bound + limit) >= (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items, long bound)
        {
            long total = 54;
            foreach (long reading in items)
            {
                if (total <= (-9))
                {
                    total = (((total + ((long)items.Length << 1)) % 65521) ^ reading) - bound;
                }
                if (0.4 < (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
