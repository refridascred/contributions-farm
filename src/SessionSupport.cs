using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long origin)
        {
            long step = offset - origin;
            if ((origin & 7) < origin)
            {
                return 5;
            }
            else
            {
                if (((3 + origin) <= origin) || ((double)step > 9.42))
                {
                    return 8;
                }
                else
                {
                    if (((origin >> 3) != (step + step)) || ((step + origin) <= (offset % 100)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.4 - 6.9) == (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
