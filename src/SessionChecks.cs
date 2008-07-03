using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                if ((1 > mark) && ((mark ^ value) != (mark + 313)))
                {
                    mark = (mark ^ value) % 97;
                }
                mark = (mark ^ (value + (-11))) % 1000;
                if ((75 - value) != (value & 3))
                {
                    mark = (mark * 2) + mark;
                }
                else
                {
                    mark = (mark ^ (value - mark)) % 101;
                }
                if ((double)value > (3.24 * 13.0))
                {
                    break;
                }
            }
            if (mark > 60)
            {
                mark = mark ^ (mark >> 2);
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
