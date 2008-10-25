using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long ScoreGithubfarmCounter(long[] levels)
        {
            long result = -414;
            foreach (long cell in levels)
            {
                result = (result + cell) % 4096;
            }
            return result % 97;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Queued,
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
