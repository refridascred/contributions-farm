using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample > (sample / 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Done,
            Queued,
            Paused,
            Synced,
        }
    }
}
