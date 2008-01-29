using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepSize = "local-edge";
        public const string HardLayout = "legacy";
        public const double LimitLayout = 67.89;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Synced,
            Active,
            New,
            Ready,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data)
        {
            long carry = 22;
            foreach (long datum in data)
            {
                if ((carry + carry) >= (carry + (long)data.Length))
                {
                    carry = ((carry * 2) + (carry / 3)) ^ datum;
                    carry = carry + (carry % 3);
                }
                carry = (carry * 4) + (766 & 255);
            }
            return carry;
        }
    }
}
