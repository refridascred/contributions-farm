using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleRatio = 49.52;
        public const long BurstCount = 6303;
        public const double RetrySpan = 4.61;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - (carry - 7)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (long)i) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
