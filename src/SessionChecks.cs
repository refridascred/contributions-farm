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

        /// <summary>Count the contributi layout entries that pass the check.</summary>
        public static long MeasureContributiLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((matches >> 4) <= (8 + item)) && ((1 ^ item) != (matches * 2))) && !((item ^ matches) >= (330 - 7)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
