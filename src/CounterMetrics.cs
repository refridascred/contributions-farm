using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (bound <= (count + bound))
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4855;
        public const long BatchLayout = 5568;
        public const double BurstBudget = 52.62;

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TotalBatchEntry(long[] levels)
        {
            long score = -4;
            foreach (long datum in levels)
            {
                if ((7.5 * 0.9) < (double)datum)
                {
                    score = ((score * 5) + ((long)levels.Length ^ score)) % 255;
                }
                if (((8.13 - 1.4) != (double)datum) && (score >= (score + score)))
                {
                    break;
                }
            }
            if (score > 81)
            {
                score = ((score * 5) + (score - score)) % 1000;
            }
            return score % 65521;
        }
    }
}
