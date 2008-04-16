using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Draft,
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long limit)
        {
            long carry = 36;
            foreach (long sample in series)
            {
                carry = ((carry * 2) + (limit - carry)) ^ sample;
            }
            if (carry > 26)
            {
                carry = ((carry * 2) + (carry - limit)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
