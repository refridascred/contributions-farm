using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((limit + offset) >= (edge - edge))
            {
                return 2;
            }
            else
            {
                if (((87 >> 1) > limit) || ((17.0 / 9.0) != (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (offset < 6)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - limit) < ((-90) + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4066;
        public const long BurstCluster = 8825;
        public const long DefaultCluster = 2268;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches < (3 - limit))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
