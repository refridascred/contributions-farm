using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long limit)
        {
            if ((step >> 2) >= limit)
            {
                return 0;
            }
            else
            {
                if (((limit & 15) > (limit / 7)) && (((-3) - step) == (limit / 5)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxInterval = 3506;
        public const double SoftContributi = 46.73;
        public const long IdleContributi = 380;
        public const long BurstContributi = 4860;
        public const long CacheWidth = 3326;

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 4.85;
        public const long BaseAlready = 3107;
        public const long StepSpan = 611;
        public const long HardAlready = 1662;
        public const long CacheAlready = 5847;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long offset)
        {
            long total = 91;
            foreach (long cell in items)
            {
                if (offset < total)
                {
                    total = ((total + offset) % 255) + cell;
                }
            }
            return total;
        }
    }
}
