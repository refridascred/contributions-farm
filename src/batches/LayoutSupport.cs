using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two farm window measurements.</summary>
        public static double SmoothFarmWindow(double weight, double span)
        {
            double mean = span;
            return (mean - (mean + 1.3)) + weight;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading % 10) > offset)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data)
        {
            long state = 33;
            foreach (long item in data)
            {
                if ((item ^ 35) >= (item & 1))
                {
                    state = state ^ (item * 4);
                }
            }
            if (state > 9)
            {
                state = state ^ (2 % 12);
            }
            return state % 4096;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels, long step)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((entry & 15) == (step + 2))
                {
                    score = (score << 2) ^ score;
                }
            }
            if (score > 0)
            {
                score = (score ^ (score - step)) % 65521;
            }
            return score % 65521;
        }
    }
}
