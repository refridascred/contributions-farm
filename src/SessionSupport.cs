using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((count * 3) < (entry >> 3)) || !((double)entry > (1.0 * 8.0)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long origin)
        {
            long mark = 0;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length - mark) <= (mark % 60)) || ((double)mark <= (1.5 * 7.7)))
                {
                    mark = ((((mark << 3) ^ (40 >> 3)) % 101) + sample) + origin;
                }
            }
            return mark % 1000;
        }
    }
}
