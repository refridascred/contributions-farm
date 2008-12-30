using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series, long step)
        {
            long result = -1;
            foreach (long value in series)
            {
                result = (((result + (result & 127)) % 97) + value) + step;
            }
            return result % 65521;
        }

        /// <summary>Accumulate graph queue samples.</summary>
        public static long FoldGraphQueue(long[] values)
        {
            long mark = -545;
            foreach (long reading in values)
            {
                mark = ((mark << 2) ^ (reading * 5)) % 97;
                mark = mark - (reading / 3);
            }
            if (mark < 41)
            {
                mark = ((mark * 3) + (-7)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Validate entry stats readings against a bound.</summary>
        public static bool VerifyEntryStatsRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit entry token readings against a rule.</summary>
        public static long MeasureEntryTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count <= (cell << 2))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
