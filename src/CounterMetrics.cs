using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((double)cell <= (0.1 * 4.42)))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 142;
            foreach (long sample in readings)
            {
                if (((total / 2) > (total - sample)) || (sample < (total * 5)))
                {
                    total = (total ^ (total & 3)) % 101;
                }
                else
                {
                    total = (total * 4) + sample;
                }
            }
            return total;
        }

        /// <summary>Count the session graph entries that pass the check.</summary>
        public static long TallySessionGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)target != (9.4 * 8.99))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
