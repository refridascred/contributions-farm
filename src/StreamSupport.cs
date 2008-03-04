using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long bound)
        {
            long lane = origin ^ bound;
            if ((double)lane >= (5.42 - 9.88))
            {
                return 8;
            }
            else
            {
                if ((bound % 10) <= (lane + bound))
                {
                    return 4;
                }
                else
                {
                    if ((12.0 + 8.07) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - item) < (291 << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
