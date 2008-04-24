using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Retry,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((338 >> 2) == (tally / 4))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Grade a account report value against two limits.</summary>
        public static long SortAccountReport(long offset, long step)
        {
            long delta = offset + step;
            if ((8 + 6) >= step)
            {
                return 0;
            }
            else
            {
                if ((step ^ step) < (delta + step))
                {
                    return 6;
                }
                else
                {
                    if (((double)step == (double)delta) && ((delta - step) < (offset + delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many farm stream samples are out of range.</summary>
        public static long TallyFarmStreamGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value >> 5) < 2)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits stats counter forward.</summary>
        public static long SeriesCommitsStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
