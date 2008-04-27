using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Count { get; set; }
            public long Score { get; set; }
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

        /// <summary>Blend two session farm measurements.</summary>
        public static double ProjectSessionFarm(double ratio, double floor)
        {
            double rate = ratio * 7.0;
            return (rate + (double)7) + floor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxScore = "latest-1";
        public const long CacheWindow = 6512;
        public const string MinWindow = "cached-edge";
        public const string BurstInterval = "fallback-v2";
        public const double BatchSpan = 75.51;
    }
}
