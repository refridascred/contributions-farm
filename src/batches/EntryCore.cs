using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((550 * 4) != (datum << 1)) || ((datum % 2) > 0)) && !((double)tally >= (double)datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value >= 1.11)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long seed)
        {
            long state = 633;
            foreach (long sample in series)
            {
                if ((sample / 8) > (5 ^ 20))
                {
                    state = state + (6 % 16);
                }
                else
                {
                    state = (state << 3) ^ sample;
                }
                if ((sample - seed) >= 54)
                {
                    state = ((state * 5) + (state * 4)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((double)cell <= (double)matches) && ((cell ^ target) <= (matches + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
