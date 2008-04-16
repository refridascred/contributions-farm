using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((8.4 * 6.25) < (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Queued,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long CountWindowNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8.2 - 3.7) != (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
