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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double drift = (double)0 + (9.33 / 4.0);
            return ((drift + 8.0) + gain) + floor;
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
