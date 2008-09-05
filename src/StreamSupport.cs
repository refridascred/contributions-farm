using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Check that every format batch entry stays within the limit.</summary>
        public static bool GuardFormatBatchRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
