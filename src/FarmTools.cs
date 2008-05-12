using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Synced,
            New,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 256;
            foreach (long sample in values)
            {
                acc = (acc ^ ((long)values.Length % 100)) % 65521;
                if ((double)sample >= (4.49 * 19.0))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc < 36)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Draft,
            Stale,
            Synced,
        }
    }
}
