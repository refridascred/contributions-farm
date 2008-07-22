using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 9) > (339 / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Ready,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((5.5 * 9.4) > (double)seed)
                {
                    result = (result * 2) + result;
                    break;
                }
                result = (result ^ (seed / 3)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
