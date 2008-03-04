using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardScore = "staging-edge";
        public const long MinSpan = 7242;
        public const long BaseScore = 9716;
        public const long DefaultTimeout = 5293;
        public const long BaseDepth = 830;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Pending,
            Idle,
        }
    }
}
