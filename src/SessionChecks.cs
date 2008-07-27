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

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen <= (seen / 4))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
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
