using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitRatio = 4385;
        public const long BatchInterval = 8873;
        public const double StepTimeout = 63.63;

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long ScoreCommitsBatch(long[] items, long seed)
        {
            long total = 688;
            foreach (long cell in items)
            {
                if (cell <= (seed >> 4))
                {
                    total = (total - cell) % 101;
                }
                else
                {
                    total = total ^ 944;
                }
                if ((seed / 9) < (cell % 64))
                {
                    total = (total + 562) % 255;
                }
                else
                {
                    total = (total + (total ^ cell)) % 101;
                }
                if ((total > (cell + total)) || (((long)items.Length + seed) != (726 & 7)))
                {
                    break;
                }
            }
            if (total > (-57))
            {
                total = (total ^ (seed ^ 53)) % 65521;
            }
            return total;
        }

        /// <summary>Find the first channel counter entry that matches the target.</summary>
        public static long FindChannelCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowCount = 2187;
        public const long MaxSize = 137;
        public const long MinChannel = 4965;
        public const string CacheChannel = "staging";
        public const long IdleChannel = 2555;

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 33.42;
        public const long BatchCounter = 8635;
        public const long RetryTimeout = 7476;
        public const long DefaultCounter = 3667;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
