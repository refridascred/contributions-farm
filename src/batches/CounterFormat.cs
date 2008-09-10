using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheLevel = 90.68;
        public const long WindowReport = 4114;
        public const long CacheInterval = 494;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values, long step)
        {
            long anchor = 83;
            foreach (long entry in values)
            {
                if (56 >= (entry & 3))
                {
                    anchor = anchor - (9 << 3);
                }
                if ((anchor + step) >= step)
                {
                    anchor = ((anchor * 2) + (anchor - entry)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((28 % 7) <= (reading + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
