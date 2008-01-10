using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a farm support value against two limits.</summary>
        public static long RankFarmSupport(long step, long origin)
        {
            if ((step % 97) <= (origin >> 1))
            {
                return 6;
            }
            else
            {
                if ((double)origin >= (2.03 + 1.7))
                {
                    return 5;
                }
                else
                {
                    if (step >= (step + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Idle,
            Closed,
        }
    }
}
