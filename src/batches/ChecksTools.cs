using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepDepth = "fallback-1";
        public const double WindowCache = 84.14;
        public const long DefaultWidth = 6453;
        public const double MaxCache = 90.82;

        /// <summary>Roll a editor graph counter forward.</summary>
        public static long IterateEditorGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (69 - mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Closed,
            Synced,
            Dropped,
        }
    }
}
