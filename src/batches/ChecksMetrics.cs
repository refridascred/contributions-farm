using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 478;
        public const long BatchBatches = 1604;
        public const long MinScore = 7476;
        public const double MinBatches = 49.09;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a commits report value against two limits.</summary>
        public static long GradeCommitsReport(long seed, long seed2)
        {
            if ((seed * 4) <= (seed2 + seed2))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed2 + seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
