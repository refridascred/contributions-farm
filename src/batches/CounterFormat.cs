using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long anchor = 61;
            foreach (long reading in samples)
            {
                if (((double)anchor > (4.5 * 2.3)) || ((seed % 3) >= anchor))
                {
                    anchor = ((anchor ^ (1 - (-10))) % 97) + reading;
                }
                else
                {
                    anchor = anchor + ((long)samples.Length + anchor);
                }
            }
            if (anchor < 78)
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long target)
        {
            if (((floor & 7) < (floor ^ floor)) && (floor < (floor ^ (-8))))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (20.0 - 10.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
