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

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
