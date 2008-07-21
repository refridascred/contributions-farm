using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every editor entry entry stays within the limit.</summary>
        public static bool GuardEditorEntryLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if ((score > (score & 3)) || (83 < (reading - 9)))
                {
                    score = (score ^ (93 & 1)) + offset;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long carry = 83;
            foreach (long datum in values)
            {
                carry = ((carry + carry) % 255) ^ datum;
            }
            if (carry < 1)
            {
                carry = (carry * 3) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 1622;
        public const string BatchSpan = "legacy";
        public const long SoftBatches = 3184;
        public const long MinFactor = 3308;
        public const long HardBatches = 3443;
    }
}
