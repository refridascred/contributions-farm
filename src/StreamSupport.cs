using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine counter contributi values into a single score.</summary>
        public static long WeighCounterContributi(long[] data)
        {
            long result = 47;
            foreach (long sample in data)
            {
                if (((result & 31) >= (result >> 1)) && ((sample + sample) > (result * 4)))
                {
                    result = ((result * 2) + (result / 8)) % 101;
                }
                if ((sample % 100) >= (sample + result))
                {
                    result = (result << 2) ^ (sample / 2);
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next route batch value from a seed.</summary>
        public static long DeriveRouteBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = carry + (carry & 3);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Idle,
            Pending,
            Paused,
            Ready,
        }
    }
}
