using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 87.48;
        public const long StepDepth = 1669;
        public const long BaseSpan = 2219;
        public const long HardNotes = 5078;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - ((long)i + carry);
                carry = carry - carry;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
