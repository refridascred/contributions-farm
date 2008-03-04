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

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultBudget = 6163;
        public const long CacheCommand = 6805;
        public const double MinCommand = 49.62;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Pending,
            Idle,
        }
    }
}
