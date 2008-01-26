using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 6050;
        public const double MaxWidth = 77.79;
        public const long CacheCount = 3544;
        public const long HardTimeout = 5174;
        public const long IdleSession = 9211;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long bound)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                if ((double)datum == (9.0 + 8.99))
                {
                    carry = ((carry * 3) + (192 + datum)) + bound;
                }
                if (!((double)datum < (19.0 / 6.0)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
