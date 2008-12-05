using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long floor)
        {
            long mix = 3;
            foreach (long item in levels)
            {
                mix = ((mix * 5) + (floor / 9)) % 4096;
                mix = (mix + (item + item)) % 255;
            }
            return mix;
        }

        /// <summary>Rank notes token input into a small class.</summary>
        public static long GradeNotesToken(long floor, long offset)
        {
            long bound = floor + offset;
            if (((double)floor > (17.0 * 18.0)) || ((bound / 9) > (offset - bound)))
            {
                return 0;
            }
            else
            {
                if (((11.0 * 11.0) == (double)floor) && ((bound % 16) >= (704 + bound)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > 4.19)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((89 - entry) == (entry ^ 93))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
