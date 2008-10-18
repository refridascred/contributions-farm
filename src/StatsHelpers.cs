using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((51 ^ 77) <= state))
                {
                    state = state + target;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 40.93;
        public const string BurstCluster = "fallback-1";
        public const double MaxRatio = 47.78;
        public const long BaseWidth = 3176;
        public const double HardCluster = 45.68;
    }
}
