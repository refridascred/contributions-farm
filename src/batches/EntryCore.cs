using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Done,
            Failed,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long seed)
        {
            long offset = step + seed;
            if ((178 + offset) > (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((double)step < 1.0)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (seed >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)seed < (6.2 + 4.85)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 3) + (181 >> 2);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((9.16 * 6.0) != (double)entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxScore = "latest-1";
        public const long CacheWindow = 6512;
        public const string MinWindow = "cached-edge";
        public const string BurstInterval = "fallback-v2";
        public const double BatchSpan = 75.51;
    }
}
