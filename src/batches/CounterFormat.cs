using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long carry = -87;
            foreach (long reading in levels)
            {
                carry = carry ^ (reading & 127);
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleLevel = 59.83;
        public const double MinProfile = 58.2;
        public const double DefaultProfile = 26.02;
    }
}
