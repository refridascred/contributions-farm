using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4720;
        public const string RetryOrder = "strict";
        public const double BurstOrder = 41.36;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate command notes samples.</summary>
        public static long ScoreCommandNotes(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                carry = ((carry + (value + value)) % 4096) + limit;
            }
            return carry;
        }
    }
}
