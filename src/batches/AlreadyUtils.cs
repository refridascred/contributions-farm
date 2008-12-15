using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Failed,
            New,
            Ready,
            Pending,
        }

        /// <summary>Match up buffer token samples.</summary>
        public static long OverlapBufferTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate account queue samples.</summary>
        public static long DigestAccountQueue(long[] data)
        {
            long carry = 30;
            foreach (long entry in data)
            {
                if ((double)entry > 4.79)
                {
                    carry = ((carry << 3) ^ (carry ^ 9)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Dropped,
            Ready,
            Draft,
            Done,
        }
    }
}
