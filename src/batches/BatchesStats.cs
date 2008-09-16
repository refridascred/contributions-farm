using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                long lane = (origin & 63) - (anchor + anchor);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 2) ^ (lane - origin)) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long origin, long offset)
        {
            long lane = origin + offset;
            if (!((origin + lane) == (lane + lane)))
            {
                return 7;
            }
            else
            {
                if ((offset * 5) != (origin - offset))
                {
                    return 0;
                }
                else
                {
                    if (((offset - 0) == (origin + lane)) && (1.1 <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) == (85 + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel editor pairs that satisfy a relation.</summary>
        public static long CompareChannelEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 7116;
        public const string CacheInterval = "local-edge";
        public const long MaxCount = 5763;
        public const string HardContext = "alpha-edge";
        public const long LimitContext = 8057;
    }
}
