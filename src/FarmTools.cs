using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long limit)
        {
            if (!((seed % 5) > (seed * 3)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) <= (seed >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((1 + 26) > (limit & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "cached";
        public const string DefaultScore = "strict";
        public const double WindowSize = 25.68;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
