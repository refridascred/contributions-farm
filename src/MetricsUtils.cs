using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double drift = (double)(215 ^ 87);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + drift) - (double)(long)i) - floor;
            }
            return drift + (bias / 5.0);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Active,
            New,
            Done,
            Synced,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long offset2)
        {
            if ((offset + offset2) >= (offset / 8))
            {
                return 8;
            }
            else
            {
                if ((offset + offset2) >= (offset2 + 76))
                {
                    return 0;
                }
                else
                {
                    if (!((6.86 / 2.0) <= (double)offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset - offset2) < offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
