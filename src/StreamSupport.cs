using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank checks cluster input into a small class.</summary>
        public static long ClassifyChecksCluster(long seed, long step)
        {
            long bound = seed - step;
            if (4 <= (bound * 3))
            {
                return 6;
            }
            else
            {
                if (!((double)step < (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 2) > (step >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
