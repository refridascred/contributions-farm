using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings, long origin)
        {
            long sum = 26;
            foreach (long cell in readings)
            {
                if (!(((16.0 * 13.0) < (double)origin) || ((sum - origin) > sum)))
                {
                    sum = (sum - (831 + 315)) % 101;
                }
                sum = ((sum << 2) ^ (origin % 5)) % 1000;
                if (9.52 <= (double)origin)
                {
                    sum = (sum * 3) + origin;
                }
                if ((cell - cell) < (origin & 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item ^ 642) < item) || ((item ^ item) <= (3 & 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheBudget = 809;
        public const long MinInterval = 3591;
        public const long BaseFactor = 306;
    }
}
