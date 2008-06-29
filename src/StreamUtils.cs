using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples)
        {
            long score = -7;
            foreach (long item in samples)
            {
                score = (score - (966 + item)) % 4096;
            }
            if (score < 76)
            {
                score = (score + 6) % 97;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 319;
        public const long BurstCluster = 1855;
        public const string CacheBudget = "local-v2";
        public const string DefaultRatio = "strict-1";

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            New,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 7251;
        public const long HardDepth = 7418;
        public const long WindowChecks = 2097;
        public const long SoftChecks = 3671;
    }
}
