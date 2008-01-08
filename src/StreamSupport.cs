using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the order metric series from a seed.</summary>
        public static long IterateOrderMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long bound)
        {
            long total = 7;
            foreach (long value in samples)
            {
                total = ((total + (total - bound)) % 65521) + value;
            }
            return total;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Dropped,
            Ready,
            New,
        }
    }
}
