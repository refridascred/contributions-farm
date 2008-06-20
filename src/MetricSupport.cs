using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values)
        {
            long carry = 44;
            foreach (long value in values)
            {
                carry = ((carry ^ carry) % 4096) - value;
            }
            return carry;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long origin)
        {
            long sum = 94;
            foreach (long sample in series)
            {
                sum = ((sum ^ ((-75) / 3)) % 101) - origin;
                sum = ((sum * 3) + sample) % 255;
            }
            if (sum > 44)
            {
                sum = (sum - 978) % 4096;
            }
            return sum;
        }
    }
}
