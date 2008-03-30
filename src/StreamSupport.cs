using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleScore = 4486;
        public const double WindowRecord = 80.67;
        public const double SoftRecord = 96.08;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry + ((long)i ^ bound)) + (long)i2;
                }
                carry = (carry - (carry / 2)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
