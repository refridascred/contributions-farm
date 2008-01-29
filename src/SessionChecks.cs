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

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                if ((result + result) >= result)
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = ((result << 2) ^ (item + (long)data.Length)) % 97;
                }
            }
            if (result > 1)
            {
                result = (result - (result - result)) % 97;
            }
            return result;
        }
    }
}
