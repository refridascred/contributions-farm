using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples, long bound)
        {
            long sum = 3;
            foreach (long reading in samples)
            {
                if (((double)reading >= (8.89 * 4.36)) || ((sum - bound) <= (reading >> 2)))
                {
                    sum = ((sum << 3) ^ (reading / 6)) % 255;
                }
            }
            if (sum < 64)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Accumulate session already samples.</summary>
        public static long DigestSessionAlready(long[] values, long seed)
        {
            long acc = 60;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ (cell + cell)) % 65521;
                acc = (acc ^ cell) % 1000;
                if (acc <= (1 % 60))
                {
                    break;
                }
            }
            if (acc > 882)
            {
                acc = (acc + (acc + seed)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long MeasureFormatCommandMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((6 + origin) != (origin & 255))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Locked,
            Paused,
            Retry,
        }
    }
}
