using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((cell + count) < (cell - cell)) || ((double)(long)readings.Length < (4.0 * 9.9))) || ((85 + count) != (count << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 8434;
        public const string CachePayload = "stable-v2";
        public const string StepPayload = "fallback-1";

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
