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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if (!(137 <= (limit >> 5)))
            {
                return 3;
            }
            else
            {
                if ((3.0 - 14.0) == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((offset & 7) <= (limit >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 12)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 3447;
        public const double MinScore = 31.14;
        public const long MaxQueue = 1592;
        public const long CacheQueue = 7043;
        public const double DefaultWidth = 67.02;
    }
}
