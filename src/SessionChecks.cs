using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double gain = (scale / 3.0) / 9.0;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - span;
            }
            return gain - (scale - 1.2);
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double offset)
        {
            double weight = (double)409 * 0.2;
            if (weight < 12.0)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (3.46 - offset)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 195;
            foreach (long item in samples)
            {
                long gap = (item / 4) + mark;
                if (((double)item < (7.85 + 9.02)) || (mark >= (gap + mark)))
                {
                    continue;
                }
                mark = mark ^ (mark - item);
                if (!((15.0 / 3.0) == (double)mark))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark * 3) + (mark << 3);
            }
            return mark;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if ((edge + origin) >= origin)
            {
                return 5;
            }
            else
            {
                if ((origin + origin2) > (891 % 7))
                {
                    return 7;
                }
                else
                {
                    if ((11.0 - 2.0) == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
