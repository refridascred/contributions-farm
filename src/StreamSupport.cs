using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8355;
        public const double BaseStream = 76.63;
        public const long HardSize = 7978;

        /// <summary>Accumulate format layout samples.</summary>
        public static long FoldFormatLayout(long[] series, long step)
        {
            long carry = 97;
            foreach (long cell in series)
            {
                if (cell >= (step % 60))
                {
                    carry = (carry ^ carry) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Dropped,
            Active,
            Queued,
            Draft,
        }
    }
}
