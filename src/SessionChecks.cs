using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 87.79;
        public const string RetryStats = "standard-1";
        public const string CacheRatio = "stable";
        public const string WindowWidth = "alpha-v2";
        public const long SoftStats = 1310;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
