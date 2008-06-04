using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long floor, long step)
        {
            long slot = floor + step;
            if ((45 + step) > (slot >> 4))
            {
                return 5;
            }
            else
            {
                if ((255 << 1) <= (step / 9))
                {
                    return 3;
                }
                else
                {
                    if ((7.62 * 9.1) <= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long DeriveContextSession(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = (score - score) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
