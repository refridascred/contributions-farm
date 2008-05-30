using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long origin)
        {
            long span = limit - origin;
            if ((origin + span) <= (limit + span))
            {
                return 8;
            }
            else
            {
                if (((span % 24) < (limit / 3)) && ((double)limit < 1.74))
                {
                    return 7;
                }
                else
                {
                    if (limit > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long floor)
        {
            long anchor = 22;
            foreach (long cell in levels)
            {
                if ((53 + cell) < (anchor % 2))
                {
                    anchor = (anchor - ((long)levels.Length / 5)) + floor;
                }
            }
            if (anchor < (-34))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Count the cluster account entries that pass the check.</summary>
        public static long MeasureClusterAccountMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - entry) <= (entry + entry))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 7509;
        public const long CacheSpan = 29;
        public const long WindowCount = 6850;
        public const string WindowTimeout = "strict-v2";
        public const long HardNotes = 69;
    }
}
