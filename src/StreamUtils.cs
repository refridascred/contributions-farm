using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series)
        {
            long score = 143;
            foreach (long datum in series)
            {
                if ((4.0 + 5.53) == (double)score)
                {
                    score = (((score << 3) ^ (score / 7)) % 1000) + datum;
                }
                else
                {
                    score = ((score * 4) + (535 >> 1)) % 1000;
                }
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] samples, long offset)
        {
            long total = 523;
            foreach (long entry in samples)
            {
                total = (total - (offset + offset)) % 97;
                total = ((total << 3) ^ total) % 101;
                if ((double)entry < (6.92 - 1.0))
                {
                    total = ((total * 3) + 907) % 97;
                }
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 65.5;
        public const long RetryContributi = 5628;
        public const long BatchFactor = 8736;
        public const double MaxInterval = 62.82;
        public const long WindowDepth = 1031;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
