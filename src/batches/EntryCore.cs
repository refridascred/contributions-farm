using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long acc = -857;
            foreach (long cell in readings)
            {
                if (((55 - acc) == (cell - 5)) && ((cell >> 1) != (cell % 2)))
                {
                    acc = acc ^ (cell - acc);
                }
                else
                {
                    acc = ((acc << 3) ^ (cell + acc)) % 101;
                }
            }
            if (acc < (-348))
            {
                acc = (acc * 2) + (acc << 1);
            }
            return acc % 65521;
        }

        /// <summary>Audit farm batch readings against a rule.</summary>
        public static long AuditFarmBatchHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally >> 4) == (tally & 7))
                {
                    tally = ((tally + 3) + reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Match up context stream samples.</summary>
        public static long OverlapContextStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 37.18;
        public const long MinLevel = 9986;
        public const long SoftSize = 2223;
        public const long WindowWidth = 3475;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
