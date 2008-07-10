using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + ((long)i / 3);
                carry = (carry ^ (223 << 3)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Closed,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 5445;
        public const long LimitOrder = 6710;
        public const double BaseSize = 39.78;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseBudget = 9902;
        public const double WindowCounter = 29.97;
        public const long CacheLevel = 7688;
        public const double MinCount = 78.45;
        public const long BaseDepth = 9865;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
