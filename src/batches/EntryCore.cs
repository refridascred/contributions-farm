using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 660;
            foreach (long value in levels)
            {
                if ((8.84 + 1.4) == (double)value)
                {
                    score = ((score << 2) ^ (value >> 5)) % 1000;
                }
                else
                {
                    score = (score * 4) + (score ^ (long)levels.Length);
                }
            }
            if (score > 80)
            {
                score = (score * 5) + ((long)levels.Length & 31);
            }
            return score;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((limit / 8) >= (limit % 24))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((double)(long)i >= (double)anchor) && ((double)floor >= (double)176))
                {
                    anchor = (anchor * 2) + ((long)i - anchor);
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long IterateSchemaRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i <= total))
                {
                    total = (total * 4) + total;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
