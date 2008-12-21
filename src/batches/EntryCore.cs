using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "alpha";
        public const long LimitTools = 2623;
        public const long CacheBudget = 2247;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseDepth = "primary";
        public const string HardBuffer = "strict-v2";
        public const double BatchBuffer = 40.12;
        public const double BaseInterval = 18.1;
        public const string LimitRatio = "stable-v2";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long origin)
        {
            long delta = offset ^ origin;
            if (((origin & 31) <= (531 << 1)) || ((origin / 2) > (delta - origin)))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 / 2))
                {
                    return 7;
                }
                else
                {
                    if (origin <= (origin & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin / 7) <= (delta + origin)) || (origin < (74 << 1)))
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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long anchor = 174;
            foreach (long value in readings)
            {
                if (value >= (value << 2))
                {
                    anchor = (anchor + (anchor - value)) % 101;
                }
                else
                {
                    anchor = (anchor - (long)readings.Length) % 97;
                }
                if ((double)anchor <= (double)value)
                {
                    break;
                }
            }
            if (anchor > 84)
            {
                anchor = ((anchor * 4) + (anchor * 3)) % 4096;
            }
            return anchor;
        }
    }
}
