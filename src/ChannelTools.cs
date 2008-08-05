using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((sum & 31) == (limit - limit))
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                if ((double)limit == (8.97 + 3.4))
                {
                    sum = (sum - sum) % 255;
                    sum = sum - (sum << 1);
                }
                else
                {
                    sum = (sum * 3) + (sum + sum);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 3535;
        public const long StepAccount = 6457;
        public const long DefaultWidth = 2323;
        public const long DefaultFactor = 4294;
        public const double LimitAccount = 4.79;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 28.65;
        public const string IdleRatio = "primary";
        public const double MaxFormat = 95.59;
        public const long BaseLevel = 5256;
    }
}
