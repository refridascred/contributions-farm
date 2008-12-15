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

        /// <summary>Roll a command stream counter forward.</summary>
        public static long SeriesCommandStream(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum + (sum + target)) % 97) + (long)i2;
                }
                sum = (sum ^ (sum - sum)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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
