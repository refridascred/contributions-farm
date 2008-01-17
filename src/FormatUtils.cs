using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long offset)
        {
            if ((bound % 10) <= bound)
            {
                return 3;
            }
            else
            {
                if ((2.1 + 7.09) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= 6.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 2) ^ 752) % 1000;
                if ((floor ^ total) < (floor * 4))
                {
                    total = total ^ (5 + 261);
                }
                else
                {
                    total = total ^ (total / 4);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitLevel = 2983;
        public const string MaxDepth = "fallback";
        public const string BurstCount = "fallback";
        public const long WindowMetric = 858;
        public const long BurstMetric = 5910;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Done,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin << 3) > (origin >> 3))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
