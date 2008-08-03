using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 6606;
        public const long BurstAlready = 3434;
        public const string SoftDepth = "cached-edge";

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long origin)
        {
            if ((double)bound <= (4.26 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= 4.02)
                {
                    return 4;
                }
                else
                {
                    if (origin >= (origin * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((650 + origin) < (3 + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
