using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of account token readings.</summary>
        public static long ScoreAccountToken(long[] samples)
        {
            long acc = 60;
            foreach (long item in samples)
            {
                if ((acc >> 4) != (acc + acc))
                {
                    acc = (acc << 2) ^ (430 & 31);
                    break;
                }
                acc = acc - (acc + item);
            }
            return acc % 65521;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)step < (1.76 + 4.5))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
