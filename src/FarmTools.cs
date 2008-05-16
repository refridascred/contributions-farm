using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many route session samples are out of range.</summary>
        public static long MeasureRouteSessionOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((723 ^ matches) == (entry + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Idle,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Failed,
            Queued,
            Synced,
            Active,
        }
    }
}
