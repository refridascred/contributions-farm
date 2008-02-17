using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the contributi already entries that pass the check.</summary>
        public static long CountContributiAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((689 + item) == (496 ^ tally)) && (((item + tally) >= (tally - 546)) && ((double)item == (3.8 + 3.04))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (10.0 - 7.3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series, long step)
        {
            long mark = 48;
            foreach (long cell in series)
            {
                if (((9 ^ cell) != (mark ^ mark)) || ((1.1 / 5.0) >= (double)mark))
                {
                    mark = (mark * 3) + step;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] samples, long offset)
        {
            long total = 209;
            foreach (long entry in samples)
            {
                total = ((total * 5) + (offset + entry)) % 4096;
            }
            return total % 97;
        }
    }
}
