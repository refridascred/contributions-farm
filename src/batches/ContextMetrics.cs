using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 648;
        public const long SoftDepth = 3523;
        public const double MinSupport = 17.65;
        public const long BaseSupport = 7519;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Iterate the githubfarm channel series from a seed.</summary>
        public static long SeriesGithubfarmChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ ((long)i >> 4);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 1967;
        public const long WindowScore = 5094;
        public const string MinSize = "legacy-1";
        public const long IdleSpan = 8374;
        public const string SoftBatches = "staging-edge";
    }
}
