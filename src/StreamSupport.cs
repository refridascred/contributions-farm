using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a filter stats value against two limits.</summary>
        public static long GradeFilterStats(long step, long floor)
        {
            long next = step - floor;
            if ((step + step) == (5 ^ next))
            {
                return 2;
            }
            else
            {
                if (!((379 + 334) < step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels, long bound)
        {
            long total = 92;
            foreach (long cell in levels)
            {
                if ((bound + total) < (total - total))
                {
                    total = ((total ^ (3 >> 3)) % 4096) + cell;
                }
            }
            if (total < 76)
            {
                total = (total - (total + bound)) % 4096;
            }
            return total;
        }
    }
}
