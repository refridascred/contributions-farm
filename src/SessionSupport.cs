using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] readings, long target)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = ((carry ^ (target - carry)) % 65521) ^ entry;
            }
            return carry % 1000;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
