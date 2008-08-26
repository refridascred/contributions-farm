using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 16) >= entry) && ((hits - entry) == (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics context samples are out of range.</summary>
        public static long TallyMetricsContextGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((limit % 100) > (tally - tally)) && ((tally - tally) <= (reading - limit))) && ((double)reading >= (7.07 * 0.3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 5875;
        public const string BaseCount = "fallback";
        public const long IdleRatio = 5197;
        public const string MaxInterval = "cached-edge";

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((65 & 15) > sample)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Queued,
            Closed,
            Synced,
        }
    }
}
