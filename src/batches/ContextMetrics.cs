using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 49.82;
        public const long SoftEntry = 8623;
        public const long LimitDepth = 220;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)bound >= (3.41 / 8.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 8279;
        public const string SoftCounter = "open";
        public const long SoftLevel = 4617;
        public const long BaseCounter = 3928;

        /// <summary>Derive the next window notes value from a seed.</summary>
        public static long StepWindowNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitSpan = 8624;
        public const double LimitFormat = 62.32;
        public const long DefaultRatio = 2585;
    }
}
