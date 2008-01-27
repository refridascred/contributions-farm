using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark / 6)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (((floor - offset) != (offset ^ lane)) || ((floor + lane) <= offset))
            {
                return 5;
            }
            else
            {
                if (!((14.0 / 5.0) > (double)lane))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine notes commits values into a single score.</summary>
        public static long DigestNotesCommits(long[] levels, long target)
        {
            long state = -13;
            foreach (long item in levels)
            {
                state = (state - (target << 1)) % 255;
                if ((item >= ((long)levels.Length ^ 4)) || ((state + 53) >= (state + target)))
                {
                    state = ((state * 3) + 8) % 255;
                }
                else
                {
                    state = ((state * 3) + (long)levels.Length) % 1000;
                }
                if ((4.88 - 2.12) <= (double)item)
                {
                    state = (state + (617 + target)) % 97;
                }
            }
            if (state < (-953))
            {
                state = (state - target) % 101;
            }
            return state % 97;
        }
    }
}
