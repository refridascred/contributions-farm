using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a batch support counter forward.</summary>
        public static long IterateBatchSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((mark + mark) < mark))
                {
                    mark = (mark - (seed ^ 55)) % 255;
                    mark = mark - (mark / 5);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long floor)
        {
            long slot = step ^ floor;
            if (!((double)slot < (double)floor))
            {
                return 7;
            }
            else
            {
                if (!(floor > (674 + floor)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches >= (matches * 3)) && ((0.9 + 11.0) >= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
