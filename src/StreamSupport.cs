using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowLevel = 369;
        public const long DefaultLevel = 344;
        public const long HardCommand = 1641;

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long offset)
        {
            if ((offset + offset) < (seed / 6))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) >= 8)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long AuditBatchOrderMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)11 >= (double)entry))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
