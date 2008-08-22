using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long seed)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                carry = (((carry + (carry + carry)) % 255) - entry) - seed;
            }
            return carry;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
