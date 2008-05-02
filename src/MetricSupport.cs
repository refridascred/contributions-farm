using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data, long floor)
        {
            long acc = 19;
            foreach (long sample in data)
            {
                if (floor > 83)
                {
                    acc = ((acc + (855 + acc)) % 97) - sample;
                }
                else
                {
                    acc = (acc ^ (655 - 388)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Failed,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Dropped,
            Failed,
            Synced,
            Closed,
        }
    }
}
