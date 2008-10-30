using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] samples)
        {
            long result = 310;
            foreach (long datum in samples)
            {
                if ((7.85 / 9.0) != (double)datum)
                {
                    result = ((result << 3) ^ datum) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Done,
            Retry,
        }
    }
}
