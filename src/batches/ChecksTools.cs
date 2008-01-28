using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Draft,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 57.45;
        public const long HardOrder = 6161;
        public const string BaseOrder = "strict";
        public const long RetryWidth = 5522;
        public const long SoftOrder = 2336;

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long step)
        {
            long carry = 8;
            foreach (long value in data)
            {
                carry = ((carry << 2) ^ (step + carry)) % 97;
                carry = ((carry << 2) ^ value) % 97;
            }
            return carry % 65521;
        }
    }
}
