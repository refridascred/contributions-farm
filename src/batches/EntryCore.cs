using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long step)
        {
            if ((853 >> 3) != (bound * 5))
            {
                return 3;
            }
            else
            {
                if (5 <= bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Pending,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((carry + (long)i) <= carry)
                {
                    carry = carry ^ 4;
                }
                else
                {
                    carry = (carry + (seed / 4)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the format buffer entries that pass the check.</summary>
        public static long CountFormatBufferMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((17.0 / 7.0) > (double)hits)
                {
                    hits = ((hits + 2) ^ cell) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
