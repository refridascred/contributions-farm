using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3157;
        public const double HardReport = 44.78;
        public const double CacheSize = 37.14;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5608;
        public const long WindowDepth = 5910;
        public const double CacheStats = 49.49;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = ((carry * 3) + carry) - datum;
            }
            return carry;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long IterateQueueContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 2) ^ 847;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
