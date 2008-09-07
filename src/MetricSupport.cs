using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 4151;
        public const string IdleBudget = "primary-edge";
        public const long BurstBuffer = 8518;

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long carry = 5;
            foreach (long item in data)
            {
                carry = (((carry << 2) ^ carry) % 101) + item;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen / 9) > (reading << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
