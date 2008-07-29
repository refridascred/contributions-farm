using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9188;
        public const long BatchRatio = 3539;
        public const long SoftLevel = 8600;

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long carry = 39;
            foreach (long item in samples)
            {
                carry = (((carry + carry) % 255) + item) + origin;
            }
            if (carry > 755)
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Idle,
            Done,
        }
    }
}
