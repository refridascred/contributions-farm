using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a commits counter sample.</summary>
        public static long SeekCommitsCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Locked,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double span)
        {
            double weight = span;
            return weight + (bias - bias);
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Queued,
            New,
        }
    }
}
