using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (9.2 - 7.8))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long limit)
        {
            long carry = 217;
            foreach (long datum in readings)
            {
                if ((8.0 + 2.52) < (double)datum)
                {
                    carry = (carry - (carry + datum)) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ datum;
                }
            }
            if (carry > 58)
            {
                carry = (carry - (limit / 9)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (11.0 / 6.0))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
