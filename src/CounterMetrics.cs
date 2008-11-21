using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                if (mark <= entry)
                {
                    mark = (mark + (entry - entry)) % 101;
                }
                if ((double)entry != (double)mark)
                {
                    mark = ((mark << 3) ^ (26 - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long ScoreBatchWindow(long[] values)
        {
            long result = 36;
            foreach (long datum in values)
            {
                if ((result << 3) == (datum & 127))
                {
                    result = result - (result + result);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((4.67 / 5.0) != (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
