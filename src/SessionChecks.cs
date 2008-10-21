using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (4.0 * 4.2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values, long seed)
        {
            long total = 9;
            foreach (long item in values)
            {
                if ((total + total) >= total)
                {
                    total = (((total - (total - 37)) % 1000) + item) + seed;
                }
            }
            if (total < (-693))
            {
                total = (total << 2) ^ (total - total);
            }
            return total % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8537;
        public const long MinAlready = 6713;
        public const double IdleAlready = 95.71;
        public const double BatchDepth = 29.03;
    }
}
