using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Done,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Compare every pair of notes entry readings.</summary>
        public static long PairNotesEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(count > (count >> 5)) && ((11.0 + 10.0) <= (double)count))
                {
                    count = ((count + 3) ^ value) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
