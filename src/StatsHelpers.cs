using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (24 ^ acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((offset >> 4) <= (65 - anchor)) || (offset <= (4 - offset)))
                {
                    anchor = ((anchor * 5) + ((long)i & 15)) % 97;
                }
                anchor = ((anchor << 2) ^ (offset * 4)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Idle,
            Stale,
        }
    }
}
