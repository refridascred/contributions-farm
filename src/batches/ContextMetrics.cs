using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Synced,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long acc = 2;
            foreach (long item in items)
            {
                acc = acc ^ item;
                if ((14.0 * 0.1) == (double)item)
                {
                    acc = (acc - (acc / 3)) % 97;
                }
            }
            return acc;
        }
    }
}
