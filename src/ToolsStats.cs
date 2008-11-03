using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally < (4.32 + 9.7))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit filter command readings against a rule.</summary>
        public static long AuditFilterCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((hits ^ hits) == (hits & 1)))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item > (item ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the stats contributi entries that pass the check.</summary>
        public static long TallyStatsContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 64) != (matches + datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell < (matches + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
