using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long step)
        {
            long score = 126;
            foreach (long datum in samples)
            {
                if ((datum + step) > (step - 8))
                {
                    score = ((score << 3) ^ (step % 100)) % 4096;
                }
                if (((score * 4) != (598 - score)) || ((score & 3) == (step >> 2)))
                {
                    score = (score + (datum >> 5)) % 101;
                }
                else
                {
                    score = (score ^ datum) % 1000;
                }
            }
            if (score > 4)
            {
                score = ((score * 4) + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9050;
        public const double DefaultSpan = 78.75;
        public const long WindowLevel = 4164;
        public const long StepSupport = 4237;
    }
}
