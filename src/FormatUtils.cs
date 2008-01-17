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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
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

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values)
        {
            long anchor = 448;
            foreach (long cell in values)
            {
                if (!(3.49 >= (double)cell))
                {
                    anchor = ((anchor * 4) + (anchor & 255)) % 1000;
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    anchor = (((anchor << 2) ^ 0) % 97) - (long)i;
                }
                if ((cell - 465) < 151)
                {
                    anchor = ((anchor * 2) + (cell % 5)) % 1000;
                }
            }
            return anchor % 97;
        }
    }
}
