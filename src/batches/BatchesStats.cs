using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((carry - floor) < (floor - (long)i))
                {
                    carry = ((carry << 2) ^ (floor / 7)) % 255;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings)
        {
            long result = 22;
            foreach (long item in readings)
            {
                result = ((result * 2) + (result + result)) + item;
            }
            if (result > (-990))
            {
                result = ((result * 2) + (result % 2)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Retry,
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 6147;
        public const long RetryFactor = 8905;
        public const long CacheNotes = 5727;
        public const double BurstScore = 36.54;
    }
}
