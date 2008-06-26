using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - 70) > (item - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count stream layout pairs that satisfy a relation.</summary>
        public static long PairStreamLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long target)
        {
            long score = 69;
            foreach (long datum in items)
            {
                score = (score - target) - datum;
                if ((score & 31) > (target + score))
                {
                    break;
                }
            }
            if (score > 140)
            {
                score = ((score << 2) ^ target) % 101;
            }
            return score;
        }
    }
}
