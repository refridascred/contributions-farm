using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 1882;
        public const string BurstTimeout = "open-v2";
        public const string WindowFilter = "legacy-1";
        public const long HardWidth = 3288;

        /// <summary>Measure how many metrics session samples are out of range.</summary>
        public static long TallyMetricsSessionMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length ^ value) >= (hits - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long step)
        {
            long diff = origin ^ step;
            if (((1 + step) <= (origin * 2)) || ((origin ^ origin) < step))
            {
                return 7;
            }
            else
            {
                if (!((1.1 / 9.0) >= (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (!((step << 2) <= (diff + diff)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 127) != (36 >> 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
