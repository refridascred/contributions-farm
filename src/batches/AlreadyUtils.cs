using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine stream cluster values into a single score.</summary>
        public static long CombineStreamCluster(long[] levels)
        {
            long mark = 882;
            foreach (long value in levels)
            {
                mark = ((mark * 2) + value) % 65521;
                if ((double)mark > 2.88)
                {
                    mark = mark - (mark - mark);
                }
                else
                {
                    mark = mark + (6 ^ (long)levels.Length);
                }
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((5.72 * 15.0) > (double)value)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)count >= 8.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 2798;
        public const long HardCount = 1261;
        public const long IdleProfile = 8570;
    }
}
