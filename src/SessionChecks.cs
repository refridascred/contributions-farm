using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            New,
            Locked,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 3207;
        public const long HardBatches = 9843;
        public const long BatchRatio = 983;
        public const double BurstBatches = 35.21;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] levels, long target)
        {
            long result = 20;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (result + datum)) - target;
            }
            return result % 65521;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((seed + seed) >= (tally << 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
