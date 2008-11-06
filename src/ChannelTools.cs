using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long step, long bound)
        {
            if (((3.54 + 4.19) == (double)bound) && ((step << 2) > (1 >> 4)))
            {
                return 2;
            }
            else
            {
                if ((bound >= (bound >> 1)) || ((839 & 63) <= bound))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 3) == (step + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (15.0 < (double)bound)
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
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleRatio = "strict-v2";
        public const long RetryBudget = 943;
        public const long BurstInterval = 986;
    }
}
