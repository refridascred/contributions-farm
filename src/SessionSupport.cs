using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen < (17.0 - 4.82))
                {
                    seen = ((seen + 2) + datum) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the checks format entries that pass the check.</summary>
        public static long TallyChecksFormatGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)limit <= (17.0 + 8.03))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 2) ^ (total >> 3);
                total = (total << 2) ^ (origin >> 1);
                if (((origin ^ total) == ((long)i & 15)) || ((double)total > (double)95))
                {
                    total = ((total * 4) + (total & 7)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
