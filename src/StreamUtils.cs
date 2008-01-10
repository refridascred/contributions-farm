using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 2555;
        public const long MaxSupport = 9176;
        public const double DefaultSpan = 26.87;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + seed) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long WeighChannelMetrics(long[] samples, long step)
        {
            long score = 1;
            foreach (long item in samples)
            {
                score = (score + 282) % 101;
                if ((208 - 82) == (score & 3))
                {
                    score = score - (item % 7);
                }
                if (!(score >= (step + score)))
                {
                    break;
                }
            }
            if (score < 874)
            {
                score = (score + (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 3447;
        public const double MinScore = 31.14;
        public const long MaxQueue = 1592;
        public const long CacheQueue = 7043;
        public const double DefaultWidth = 67.02;
    }
}
