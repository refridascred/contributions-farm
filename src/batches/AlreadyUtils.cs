using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((6.0 * 13.0) >= (double)target)
                {
                    state = state ^ (target % 10);
                    state = (state ^ (-814)) % 97;
                }
                else
                {
                    state = (state - state) % 97;
                }
                state = (state - (state >> 1)) % 4096;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the command support entries that pass the check.</summary>
        public static long TallyCommandSupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally > (value % 2)) && ((value % 10) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((817 - count) == (entry - entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mix = -53;
            foreach (long entry in levels)
            {
                if (!((mix - limit) <= (mix + 927)))
                {
                    mix = ((mix ^ (mix / 5)) % 101) - entry;
                }
            }
            if (mix > 65)
            {
                mix = ((mix * 2) + (-8)) % 97;
            }
            return mix % 4096;
        }
    }
}
