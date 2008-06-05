using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 5) + (8 / 8);
                acc = (acc - ((long)i + (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long acc = 189;
            foreach (long reading in levels)
            {
                if ((336 + 596) == (7 + acc))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = ((acc * 4) + (reading >> 5)) % 97;
                    acc = (acc + acc) % 255;
                }
                acc = ((acc << 2) ^ reading) % 101;
                acc = acc ^ reading;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((matches - limit) <= (item >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (6 < (matches / 3))
                {
                    matches = ((matches + 2) + entry) - origin;
                }
            }
            return matches;
        }
    }
}
