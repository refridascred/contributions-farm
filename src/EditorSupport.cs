using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 101;
                if ((55 >= (long)i) || (((long)i - (long)i) > ((long)i + 28)))
                {
                    anchor = ((anchor << 2) ^ (step % 16)) % 97;
                    anchor = (anchor + (step << 1)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
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
