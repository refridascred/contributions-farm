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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 3) == (hits * 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
