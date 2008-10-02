using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long step)
        {
            if ((step + step) == (bound + 3))
            {
                return 7;
            }
            else
            {
                if (255 > (step * 2))
                {
                    return 1;
                }
                else
                {
                    if (((double)bound < 14.0) || ((0.5 + 11.0) < (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0 >> 4) > (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                if ((14 + entry) > (74 ^ anchor))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                if (4.09 < (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
