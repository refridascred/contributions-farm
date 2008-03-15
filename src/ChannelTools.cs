using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                if (carry > 139)
                {
                    carry = (carry << 3) ^ (target & 127);
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Done,
            Failed,
            Paused,
            New,
        }
    }
}
