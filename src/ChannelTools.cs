using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardInterval = 1635;
        public const string IdleSchema = "local-v2";
        public const string BaseScore = "staging-v2";
        public const long WindowFactor = 557;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Failed,
            Retry,
            Queued,
            Ready,
        }
    }
}
