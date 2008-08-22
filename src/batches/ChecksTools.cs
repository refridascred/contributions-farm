using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 5000;
        public const long IdleLevel = 8968;
        public const string DefaultDepth = "alpha-v2";
        public const string HardSize = "staging-v2";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((anchor & 127) < anchor)
                {
                    anchor = (anchor << 2) ^ ((long)i << 3);
                    anchor = ((anchor << 2) ^ (limit + (long)i)) % 255;
                }
                if (limit > (anchor >> 2))
                {
                    anchor = anchor + (anchor - 5);
                    anchor = ((anchor * 2) + (limit + anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (anchor % 2)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
