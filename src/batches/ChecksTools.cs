using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double scale = gain;
            if (scale < (5.0 - scale))
            {
                scale = (scale + 6.0) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 9.0) - (double)(long)i;
            }
            return scale - (scale * 3.74);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8202;
        public const string WindowToken = "standard-1";
        public const long BaseDepth = 5276;
        public const double MinRatio = 32.74;

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9407;
        public const long LimitFactor = 2894;
        public const long DefaultBatch = 1963;
        public const long StepBatch = 5834;
    }
}
