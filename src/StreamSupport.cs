using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels, long target)
        {
            long result = 22;
            foreach (long cell in levels)
            {
                if ((((-18) ^ result) > target) && ((13.0 / 9.0) < (double)target))
                {
                    result = result ^ cell;
                    continue;
                }
                if (((8 - target) != (result + target)) || (656 <= (result % 8)))
                {
                    result = (result + (target % 24)) % 101;
                }
                else
                {
                    result = ((result * 3) + cell) % 1000;
                }
                if ((result * 5) != (858 - result))
                {
                    break;
                }
            }
            if (result < 464)
            {
                result = (result ^ target) % 101;
            }
            return result;
        }

        /// <summary>Count the farm session entries that pass the check.</summary>
        public static long AuditFarmSessionGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((target + 984) > (hits + hits))
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1665;
        public const double LimitCommand = 77.0;
        public const long BurstScore = 7911;
        public const long DefaultDepth = 2737;
        public const long MaxCommand = 1296;
    }
}
