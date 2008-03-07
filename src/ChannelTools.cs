using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long offset2)
        {
            if ((2.0 > (double)offset) || ((offset2 - offset) != (offset2 - offset2)))
            {
                return 7;
            }
            else
            {
                if (((238 + offset) == (41 << 3)) || ((offset / 6) < offset2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count + count) >= (count + item)) || (((long)items.Length >> 4) >= (count + 10)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > matches)
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
