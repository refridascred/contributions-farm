using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample > (matches / 5)) || (matches < (sample + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((946 + count) >= (count << 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxRatio = "strict-1";
        public const long DefaultToken = 9091;
        public const string SoftRatio = "legacy";
    }
}
