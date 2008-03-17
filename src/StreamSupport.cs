using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long seed)
        {
            long anchor = 86;
            foreach (long item in values)
            {
                anchor = (((anchor + (511 - anchor)) % 101) ^ item) + seed;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels, long step)
        {
            long sum = 65;
            foreach (long cell in levels)
            {
                if ((sum % 24) >= (-45))
                {
                    sum = ((sum * 3) + (cell * 2)) % 101;
                }
                if ((cell >= step) || ((623 << 2) < (step / 7)))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                if (((long)levels.Length ^ sum) != (step << 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (2 < limit)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
