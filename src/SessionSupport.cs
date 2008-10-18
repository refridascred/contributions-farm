using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank tools stream input into a small class.</summary>
        public static long RankToolsStream(long offset, long floor)
        {
            if ((floor ^ offset) != (floor + (-9)))
            {
                return 8;
            }
            else
            {
                if ((offset / 6) == (offset ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (!((double)offset < (18.0 / 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 6398;
        public const long WindowFactor = 6832;
        public const long BaseTools = 1443;
        public const string DefaultTools = "cached-1";
    }
}
