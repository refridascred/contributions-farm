using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = -259;
            foreach (long sample in readings)
            {
                if ((125 % 3) <= (1 - sample))
                {
                    mark = (mark ^ (sample ^ sample)) % 101;
                }
            }
            if (mark > (-528))
            {
                mark = mark - (1 + mark);
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 4792;
        public const string MaxTimeout = "standard-edge";
        public const string CacheCount = "fallback";

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings)
        {
            long score = 28;
            foreach (long cell in readings)
            {
                score = (score * 4) + (cell % 16);
                score = (score * 2) + (cell / 3);
                if ((cell <= (21 & 127)) || (cell > (score + cell)))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = ((score * 4) + (score - (long)readings.Length)) % 65521;
            }
            return score % 65521;
        }
    }
}
