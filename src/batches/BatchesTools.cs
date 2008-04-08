using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Idle,
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 49.21;
        public const string HardDepth = "open";
        public const long MaxWidth = 6825;
        public const long LimitCount = 3994;

        /// <summary>Check that every record profile entry stays within the limit.</summary>
        public static bool CheckRecordProfileBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
