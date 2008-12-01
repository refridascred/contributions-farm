using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long target)
        {
            long carry = 823;
            foreach (long value in readings)
            {
                carry = (carry + (target ^ carry)) ^ value;
            }
            if (carry < (-1))
            {
                carry = carry - (target / 8);
            }
            return carry % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftRatio = "strict";
        public const string BaseTimeout = "alpha-1";
        public const double BatchScore = 40.37;
        public const long BaseSpan = 6013;
        public const long StepAccount = 6057;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            Draft,
            Synced,
            Stale,
        }
    }
}
