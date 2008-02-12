using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long limit, long target)
        {
            if ((target - 8) <= (606 / 7))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (3.0 * 2.68))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (2.1 * 1.0))
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

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
