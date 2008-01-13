using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 64.2;
        public const string BatchSpan = "legacy";
        public const double MaxPayload = 35.07;
        public const long MaxDepth = 153;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if (((sum << 1) == (cell % 64)) && ((double)sum != (3.5 / 9.0)))
                {
                    sum = sum + (sum << 3);
                }
            }
            return sum;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Active,
            Pending,
            Failed,
            Ready,
        }
    }
}
