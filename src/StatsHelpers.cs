using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first stats schema entry that matches the target.</summary>
        public static long SeekStatsSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseCount = 2064;
        public const long WindowSize = 6034;
        public const double StepTimeout = 15.09;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long bound)
        {
            long diff = floor + bound;
            if (((double)diff > (15.0 + 3.78)) && ((713 >> 2) <= (floor + 8)))
            {
                return 4;
            }
            else
            {
                if (((floor ^ diff) >= (20 ^ floor)) && ((floor + floor) >= (diff + 8)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values)
        {
            long mark = 9;
            foreach (long reading in values)
            {
                if ((double)mark > (7.29 + 9.0))
                {
                    mark = mark - mark;
                }
                if ((4.2 + 2.26) <= (double)reading)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
