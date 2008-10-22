using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Closed,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of checks window entries.</summary>
        public static long ScoreChecksWindow(long[] data)
        {
            long score = 214;
            foreach (long cell in data)
            {
                score = (score - (long)data.Length) - cell;
            }
            if (score < 177)
            {
                score = score + (9 << 2);
            }
            return score % 1000;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Ready,
            Pending,
            Retry,
            Draft,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Paused,
            Failed,
            Ready,
            Done,
        }
    }
}
