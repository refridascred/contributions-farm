using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Ready,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Pending,
            Locked,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((0.8 + 1.31) < (double)seed)
                {
                    sum = sum + (seed - seed);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
