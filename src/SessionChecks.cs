using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items, long seed)
        {
            long score = 7;
            foreach (long item in items)
            {
                score = (score - seed) - item;
                score = score - 84;
                if ((long)items.Length >= (score & 63))
                {
                    break;
                }
            }
            if (score > 63)
            {
                score = (score << 3) ^ (score << 1);
            }
            return score;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Dropped,
            Active,
            Ready,
            Stale,
        }
    }
}
