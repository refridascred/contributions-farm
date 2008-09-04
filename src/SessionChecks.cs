using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of report cluster entries.</summary>
        public static long ScoreReportCluster(long[] values, long offset)
        {
            long state = -69;
            foreach (long reading in values)
            {
                if ((75 - state) >= offset)
                {
                    state = (state << 2) ^ reading;
                }
            }
            return state;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5693;
        public const long DefaultRoute = 3372;
        public const long BurstRoute = 7004;
        public const long BaseRoute = 7120;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 57.0;
        public const long MaxLevel = 6042;
        public const double MinCache = 67.46;
    }
}
