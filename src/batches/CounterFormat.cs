using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long carry = 89;
            foreach (long item in data)
            {
                carry = (carry ^ (item & 255)) % 101;
                carry = (carry << 3) ^ (carry + item);
            }
            if (carry < 863)
            {
                carry = carry - (carry << 1);
            }
            return carry;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = -810;
            foreach (long cell in readings)
            {
                mix = (mix << 3) ^ (mix + cell);
            }
            return mix;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            New,
            Paused,
            Locked,
        }
    }
}
