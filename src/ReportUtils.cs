using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (80 > (hits >> 1))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + (origin / 9)) % 1000;
                if (carry < (origin % 5))
                {
                    carry = (carry * 4) + (origin + carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 218;
        public const long StepPayload = 5469;
        public const string BatchSpan = "primary";
        public const long BatchPayload = 1394;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Failed,
            Paused,
            Dropped,
            Idle,
        }
    }
}
