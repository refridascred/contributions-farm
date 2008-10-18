using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate order token readings against a bound.</summary>
        public static bool CheckOrderTokenBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((hits << 2) >= (hits >> 4)) && ((hits <= (450 - entry)) && ((entry << 2) <= hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultScore = 63.07;
        public const long BaseAccount = 4571;
        public const long WindowAccount = 8290;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 40.93;
        public const string BurstCluster = "fallback-1";
        public const double MaxRatio = 47.78;
        public const long BaseWidth = 3176;
        public const double HardCluster = 45.68;
    }
}
