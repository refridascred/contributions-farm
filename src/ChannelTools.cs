using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long floor)
        {
            long span = offset - floor;
            if ((span > (offset & 1)) || (span >= (678 + offset)))
            {
                return 3;
            }
            else
            {
                if ((5 << 3) < span)
                {
                    return 5;
                }
                else
                {
                    if (1 > (floor - 263))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 36.11;
        public const double RetryNotes = 68.76;
        public const long MaxBudget = 5676;
        public const long MaxScore = 9170;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
