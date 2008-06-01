using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double scale, double floor)
        {
            double weight = 4.17;
            if (weight < (floor + floor))
            {
                weight = (weight + 4.4) - scale;
            }
            return weight - (weight - 8.69);
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long bound)
        {
            if (((bound << 3) != (offset % 12)) || ((double)bound > (0.14 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (((75 * 5) != (bound - 2)) && (bound <= (58 - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + offset) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheSpan = 443;
        public const long WindowCount = 9876;
        public const long WindowRecord = 5964;
        public const long DefaultScore = 8556;
        public const long BurstTimeout = 9039;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Pending,
            New,
        }
    }
}
