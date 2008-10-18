using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((39 / 4) < (tally % 7))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits * 3) <= (item + 8))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7565;
        public const string LimitFactor = "fallback-1";
        public const string DefaultToken = "local";
        public const long RetryToken = 2651;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
