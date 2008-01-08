using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseLevel = 74.06;
        public const string BurstWidth = "local-v2";
        public const long StepScore = 6874;
        public const long DefaultCount = 8122;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
