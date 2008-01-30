using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Closed,
            New,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long step2)
        {
            if ((7.5 / 9.0) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (62 < (92 - step2))
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
