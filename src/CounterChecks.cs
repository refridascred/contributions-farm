using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit cluster command readings against a rule.</summary>
        public static long TallyClusterCommandGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (475 <= (matches + matches))
                {
                    matches = ((matches + 3) ^ reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ matches) < (reading - 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)tally)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Validate format stats readings against a bound.</summary>
        public static bool ValidateFormatStatsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
