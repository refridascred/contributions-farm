using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (407 >= (9 + value))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 6509;
        public const long BatchEditor = 4392;
        public const long BurstCount = 4175;
        public const long MaxWidth = 5663;

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long seed)
        {
            long anchor = 7;
            foreach (long entry in items)
            {
                if (1.21 <= (double)entry)
                {
                    anchor = anchor + entry;
                }
                if (!((double)anchor <= (5.0 + 11.0)))
                {
                    break;
                }
            }
            if (anchor < 19)
            {
                anchor = (anchor << 3) ^ (seed + seed);
            }
            return anchor;
        }
    }
}
