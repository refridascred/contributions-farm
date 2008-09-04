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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
