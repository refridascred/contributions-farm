using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every entry schema entry stays within the limit.</summary>
        public static bool VerifyEntrySchemaRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 66.13;
        public const double CacheDepth = 1.48;
        public const long LimitBatches = 8381;

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values)
        {
            long carry = 62;
            foreach (long datum in values)
            {
                carry = (carry * 2) + (datum & 31);
            }
            if (carry < 96)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry % 65521;
        }
    }
}
