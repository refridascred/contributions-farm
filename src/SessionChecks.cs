using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ tally) == (value + 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            if (((2.0 * 1.1) <= (double)offset) && ((offset + offset) >= offset2))
            {
                return 0;
            }
            else
            {
                if ((3.7 / 3.0) > (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset2) < (offset2 & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.5 + 8.3) == (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 12) != (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
