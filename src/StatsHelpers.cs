using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(entry >= (7 - entry)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally + tally) <= (951 - tally)) || ((sample - tally) == (tally - tally))) && ((step + sample) > (step ^ sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit format tools readings against a rule.</summary>
        public static long AuditFormatToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (2.71 >= (double)matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
