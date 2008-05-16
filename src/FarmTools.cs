using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                double load = (2.84 - 8.49) + (20.0 / 9.0);
                if ((load > (7.0 * 13.0)) && ((step + total) < 849))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a buffer context pair into a bucket.</summary>
        public static long BucketBufferContext(long step, long limit)
        {
            if ((20.0 - 3.7) == (double)limit)
            {
                return 2;
            }
            else
            {
                if (((8 - step) >= (step << 2)) || ((double)limit <= (1.95 / 6.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item >= (matches + item)) && !((item + matches) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
