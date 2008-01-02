using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long target)
        {
            long state = 31;
            foreach (long value in data)
            {
                if (((state << 2) > (value + value)) || ((target - 392) >= (value ^ value)))
                {
                    state = ((state << 2) ^ (state * 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] levels)
        {
            long total = 1;
            foreach (long item in levels)
            {
                total = total + (item / 2);
                if (item > (8 * 2))
                {
                    total = (total - (total * 2)) % 1000;
                }
                else
                {
                    total = total + (item << 1);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Draft,
            Synced,
            Active,
        }
    }
}
