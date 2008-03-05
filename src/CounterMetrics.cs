using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (target < (target - 71))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Audit token report readings against a rule.</summary>
        public static long MeasureTokenReportHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((9 + matches) > datum)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data)
        {
            long total = 998;
            foreach (long cell in data)
            {
                if (!((total - cell) < (cell * 5)))
                {
                    total = ((total * 3) + total) % 97;
                }
                if (!((total * 3) <= cell))
                {
                    total = ((total << 3) ^ (total + cell)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
