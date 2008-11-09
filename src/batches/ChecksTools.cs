using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 4153;
        public const long LimitFilter = 9436;
        public const double DefaultFilter = 90.22;
        public const long SoftFilter = 9408;
        public const long HardFilter = 6395;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long step, long seed)
        {
            if ((9.0 / 6.0) <= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((8 - step) == (seed - step))
                {
                    return 3;
                }
                else
                {
                    if (5.34 >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Idle,
            Pending,
            Draft,
            Dropped,
        }
    }
}
