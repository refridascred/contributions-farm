using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "alpha-edge";
        public const string BatchCommits = "legacy";
        public const string LimitLevel = "local-1";

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
