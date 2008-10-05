using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + tally) == (tally ^ 686)) && (((tally + tally) != (549 >> 3)) || ((0.44 - 0.1) < (double)item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long step, long offset)
        {
            if (!((step & 15) < (21 / 5)))
            {
                return 8;
            }
            else
            {
                if ((step / 8) <= (offset & 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = carry ^ step;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= (8.7 - 2.34))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
