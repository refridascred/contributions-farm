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

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor >= (4.0 + 6.0))
                {
                    continue;
                }
                anchor = ((anchor << 3) ^ (floor - (long)i)) % 97;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
