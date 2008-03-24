using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank graph queue input into a small class.</summary>
        public static long SortGraphQueue(long limit, long origin)
        {
            if (!((limit / 4) > (origin ^ limit)))
            {
                return 1;
            }
            else
            {
                if ((limit / 5) != (limit ^ (-400)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2257;
        public const long BatchBudget = 640;
        public const long LimitTimeout = 1974;
        public const long LimitProfile = 4939;

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "primary-1";
        public const double DefaultPayload = 19.45;
        public const long MaxPayload = 1294;
        public const long SoftPayload = 4978;
        public const double BasePayload = 87.77;
    }
}
