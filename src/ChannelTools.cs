using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache already samples.</summary>
        public static long TotalCacheAlready(long[] series, long offset)
        {
            long sum = 3;
            foreach (long value in series)
            {
                sum = (sum + offset) - value;
            }
            if (sum > 7)
            {
                sum = sum - (-862);
            }
            return sum;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values)
        {
            long carry = 27;
            foreach (long reading in values)
            {
                if ((carry % 8) != (reading + 940))
                {
                    carry = carry + (carry & 7);
                }
            }
            if (carry < 3)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }
    }
}
