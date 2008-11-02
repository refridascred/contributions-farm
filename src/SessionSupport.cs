using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((count + count) <= (count - count)) || ((7.5 >= (double)reading) || ((reading + reading) > count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 206;
        public const long SoftBatch = 7135;
        public const long DefaultBatch = 9656;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = (score - (51 + target)) % 97;
                if ((target << 1) == ((long)i * 4))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
