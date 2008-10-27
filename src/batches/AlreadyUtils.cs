using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Idle,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Check that every contributi payload entry stays within the limit.</summary>
        public static bool GuardContributiPayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 9445;
        public const long WindowScore = 271;
        public const long MinInterval = 8531;
        public const long BatchDepth = 1899;
        public const string StepTools = "latest-1";
    }
}
