using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool ValidateToolsCounterRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
