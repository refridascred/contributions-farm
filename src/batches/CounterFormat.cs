using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Paused,
            Failed,
            Ready,
            Idle,
        }

        /// <summary>Count the stream queue entries that pass the check.</summary>
        public static long TallyStreamQueueHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 3) == (46 + 9))
                {
                    seen = ((seen + 2) - cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Draft,
            Retry,
            Stale,
        }
    }
}
