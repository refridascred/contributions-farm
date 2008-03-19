using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 2078;
        public const long MinCount = 3577;
        public const long IdleMetrics = 2207;
        public const double LimitMetrics = 83.54;

        /// <summary>Roll a account batch counter forward.</summary>
        public static long SeriesAccountBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + ((long)i + floor)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of cluster route readings.</summary>
        public static long TallyClusterRoute(long[] items, long offset)
        {
            long anchor = 7;
            foreach (long entry in items)
            {
                if ((78 - 8) <= offset)
                {
                    anchor = ((anchor + (anchor & 31)) % 101) + entry;
                }
            }
            if (anchor < 27)
            {
                anchor = anchor + offset;
            }
            return anchor % 1000;
        }
    }
}
