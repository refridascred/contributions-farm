using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                carry = (((carry * 2) + (carry % 2)) % 65521) + cell;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 18.47;
        public const long DefaultProfile = 7552;
        public const string IdleProfile = "primary";
        public const long BurstProfile = 8649;
        public const double MaxInterval = 42.75;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
