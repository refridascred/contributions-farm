using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first counter context entry that matches the target.</summary>
        public static long FindCounterContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Failed,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 8999;
        public const long WindowLayout = 652;
        public const long WindowDepth = 4946;
    }
}
