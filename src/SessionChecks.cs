using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheRatio = 4549;
        public const long StepRatio = 1113;
        public const long HardBuffer = 3170;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "latest-edge";
        public const string WindowSize = "local-v2";
        public const long BurstSize = 5211;
        public const long BaseReport = 2901;
        public const string HardLevel = "legacy";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits != (double)step)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
