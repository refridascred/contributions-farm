using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 1.02;
        public const string LimitWidth = "cached-v2";
        public const long RetryRatio = 5488;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Done,
            Retry,
        }
    }
}
