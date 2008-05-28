using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark + 400) % 101) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate session token readings against a bound.</summary>
        public static bool GuardSessionTokenLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
