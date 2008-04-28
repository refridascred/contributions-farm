using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 9.23;
        public const double MaxChannel = 50.91;
        public const long BurstChannel = 3669;
        public const long HardChannel = 1119;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
