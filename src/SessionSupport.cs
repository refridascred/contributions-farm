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

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
