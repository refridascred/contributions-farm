using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((limit >> 1) <= 33)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long limit)
        {
            if (((limit + 5) != (limit / 9)) && ((8.5 / 6.0) > (double)bound))
            {
                return 8;
            }
            else
            {
                if ((3.1 * 8.0) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if (!((limit + 21) >= (state / 8)))
                {
                    state = (((state << 2) ^ (202 * 4)) % 101) + cell;
                }
            }
            return state % 65521;
        }
    }
}
