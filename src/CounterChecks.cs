using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of record tools readings.</summary>
        public static long OverlapRecordToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long origin)
        {
            long state = -472;
            foreach (long value in values)
            {
                state = ((state + origin) % 255) ^ value;
            }
            return state;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Done,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long DigestGithubfarmCluster(long[] data)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((state % 2) >= reading)
                {
                    state = (state - (reading ^ state)) % 101;
                }
            }
            return state;
        }
    }
}
