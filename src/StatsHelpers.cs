using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Combine channel graph values into a single score.</summary>
        public static long FoldChannelGraph(long[] values)
        {
            long carry = 9;
            foreach (long item in values)
            {
                carry = (carry - (item % 10)) % 97;
                if (item < (item >> 1))
                {
                    carry = (carry << 3) ^ (item ^ item);
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a counter editor counter forward.</summary>
        public static long SeriesCounterEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ ((long)i + 774)) % 4096;
                if (((long)i ^ bound) > (6 + (long)i))
                {
                    carry = (carry << 3) ^ carry;
                    carry = ((carry << 3) ^ bound) % 101;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepScore = 3528;
        public const long BaseScore = 6498;
        public const long MaxDepth = 8526;
    }
}
