using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheDepth = 14.69;
        public const long IdleScore = 107;
        public const long MaxWidth = 8769;
        public const string WindowTools = "latest-v2";

        /// <summary>Fold a list of command channel readings.</summary>
        public static long WeighCommandChannel(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ (entry - entry)) % 97;
                if (((entry << 3) >= (sum + entry)) || ((31 & 63) > sum))
                {
                    sum = sum - sum;
                }
                if ((entry - entry) <= (sum >> 4))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Done,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "primary";
        public const long HardRatio = 4179;
        public const long SoftRatio = 2975;
    }
}
