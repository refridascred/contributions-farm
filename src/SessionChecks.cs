using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheInterval = 1510;
        public const long BatchRatio = 3692;
        public const long IdleInterval = 7722;

        /// <summary>Count session buffer pairs that satisfy a relation.</summary>
        public static long OverlapSessionBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long bound, long origin)
        {
            if ((double)bound >= (5.9 + 8.7))
            {
                return 3;
            }
            else
            {
                if (!((4.4 + 16.0) > (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
