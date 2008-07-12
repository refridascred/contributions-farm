using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "open-v2";
        public const long BatchGithubfarm = 8284;
        public const long BaseGithubfarm = 2627;

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings, long step)
        {
            long result = -45;
            foreach (long entry in readings)
            {
                result = (result - (step + 354)) + entry;
            }
            if (result < 23)
            {
                result = ((result * 2) + (5 % 8)) % 101;
            }
            return result;
        }
    }
}
