using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items)
        {
            long carry = -848;
            foreach (long sample in items)
            {
                if (4 <= (sample - sample))
                {
                    carry = carry ^ (carry + sample);
                }
            }
            return carry;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            New,
            Failed,
        }
    }
}
