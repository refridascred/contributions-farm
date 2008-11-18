using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batches command readings against a rule.</summary>
        public static long CountBatchesCommandGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((63 ^ count) <= target) && (((count >> 4) != (count - count)) || ((value / 6) == (value / 5))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Paused,
            New,
        }
    }
}
