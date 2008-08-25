using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 6053;
        public const long LimitLevel = 9427;
        public const long BaseSize = 271;
        public const string DefaultInterval = "legacy-v2";
        public const long CacheDepth = 6016;

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long DeriveEditorChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((3 * 3) < seed)
                {
                    mark = (mark - (13 ^ seed)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (seed + mark)) % 97;
                }
                if ((mark >= (98 << 1)) && ((9.2 - 9.38) < (double)mark))
                {
                    mark = ((mark * 3) + ((long)i << 3)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
