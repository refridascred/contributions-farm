using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "latest-v2";
        public const long StepAlready = 9698;
        public const string BatchRatio = "cached-v2";

        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long RankClusterFarm(long step, long seed)
        {
            if (!((double)step > (8.6 - 1.0)))
            {
                return 0;
            }
            else
            {
                if ((417 + 665) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((6.0 / 7.0) != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values, long bound)
        {
            long anchor = -477;
            foreach (long item in values)
            {
                if (!(item < (item - item)))
                {
                    anchor = (anchor + (bound - anchor)) % 4096;
                }
                if (((item - (long)values.Length) < item) && (5.22 < (double)bound))
                {
                    anchor = anchor + (anchor * 2);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (item - anchor)) % 97;
                }
            }
            if (anchor < 49)
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor % 97;
        }
    }
}
