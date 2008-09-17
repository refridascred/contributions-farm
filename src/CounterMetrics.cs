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

        /// <summary>Compare every pair of format order readings.</summary>
        public static long PairFormatOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxRatio = "strict-1";
        public const long DefaultToken = 9091;
        public const string SoftRatio = "legacy";
    }
}
