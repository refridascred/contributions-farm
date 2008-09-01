using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Locked,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels)
        {
            long carry = 3;
            foreach (long entry in levels)
            {
                if ((27 - carry) >= (7 * 2))
                {
                    carry = (carry - (carry + entry)) % 101;
                }
                else
                {
                    carry = (carry + (entry * 3)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (242 + anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
