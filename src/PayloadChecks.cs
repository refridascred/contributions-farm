using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Closed,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowTimeout = 67.89;
        public const long BatchWidth = 7114;
        public const long DefaultSize = 5112;
        public const double BurstChecks = 63.89;
        public const long DefaultSpan = 5182;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items)
        {
            long total = 169;
            foreach (long cell in items)
            {
                if ((47 - 503) <= total)
                {
                    total = (((total << 2) ^ (total << 3)) % 97) + cell;
                }
                if ((16.0 + 2.2) != (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item > (item - target))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((1 >= tally) || ((tally * 4) <= cell))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}
