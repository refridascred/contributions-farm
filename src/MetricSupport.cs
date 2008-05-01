using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values, long seed)
        {
            long carry = 630;
            foreach (long value in values)
            {
                if ((value - value) != (68 % 60))
                {
                    carry = (carry ^ (value & 1)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (356 + seed)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseSpan = 54.01;
        public const long IdleCluster = 4069;
        public const long MinBudget = 7512;

        /// <summary>Fold a list of stream context readings.</summary>
        public static long TallyStreamContext(long[] samples, long target)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                carry = ((carry * 5) + (datum + datum)) % 1000;
                if (!((double)datum > (13.0 / 7.0)))
                {
                    carry = (carry - (target >> 1)) % 1000;
                }
            }
            return carry;
        }
    }
}
