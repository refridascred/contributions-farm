using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Draft,
            Active,
        }

        /// <summary>Classify a stream support pair into a bucket.</summary>
        public static long SortStreamSupport(long origin, long origin2)
        {
            if ((939 << 1) > origin2)
            {
                return 3;
            }
            else
            {
                if ((9.0 * 19.0) <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry << 3) ^ ((long)i & 127);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
