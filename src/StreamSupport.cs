using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Ready,
            Failed,
            New,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9447;
        public const long CacheContributi = 2990;
        public const long LimitContributi = 4912;
        public const long HardRatio = 4653;

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long total = 8;
            foreach (long entry in items)
            {
                if ((total + 9) == (long)items.Length)
                {
                    total = ((total + total) % 101) ^ entry;
                }
                else
                {
                    total = (total - (total << 3)) % 101;
                }
            }
            if (total < 259)
            {
                total = ((total << 3) ^ (total + 321)) % 101;
            }
            return total % 65521;
        }
    }
}
