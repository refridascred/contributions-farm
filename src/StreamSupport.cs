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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long target)
        {
            long result = 530;
            foreach (long cell in values)
            {
                if ((long)values.Length < (target >> 2))
                {
                    result = ((result - (result & 1)) % 65521) - cell;
                }
                else
                {
                    result = (result + 12) % 4096;
                }
            }
            return result;
        }
    }
}
