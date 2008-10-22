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

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings)
        {
            long sum = 87;
            foreach (long cell in readings)
            {
                sum = (sum + (sum / 6)) + cell;
            }
            return sum;
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
