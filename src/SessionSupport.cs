using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many checks entry samples are out of range.</summary>
        public static long AuditChecksEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(((item + matches) > (item >> 2)) && ((matches << 1) >= item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long origin)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                mark = ((mark ^ (origin << 3)) % 97) - reading;
            }
            if (mark > 8)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
