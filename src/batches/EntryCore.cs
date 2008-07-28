using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)hits >= 6.84) || ((7.3 * 1.0) >= (double)hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + offset) - (double)(long)i;
            }
            return ratio - (rate + rate);
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series, long step)
        {
            long anchor = 2;
            foreach (long datum in series)
            {
                if (((datum - 14) != (5 + datum)) && ((double)24 != (double)step))
                {
                    anchor = ((anchor * 2) + step) % 101;
                }
            }
            if (anchor > 70)
            {
                anchor = (anchor ^ (step % 5)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long target, long seed)
        {
            long slot = target ^ seed;
            if ((9.1 - 2.22) != (double)slot)
            {
                return 2;
            }
            else
            {
                if (seed <= (seed ^ slot))
                {
                    return 7;
                }
                else
                {
                    if ((slot - seed) > (9 * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long offset)
        {
            long sum = 107;
            foreach (long entry in levels)
            {
                if (((entry >> 5) < (entry * 4)) || (6 < (3 ^ sum)))
                {
                    sum = (sum ^ entry) - offset;
                }
                else
                {
                    sum = (sum - (long)levels.Length) % 97;
                }
            }
            return sum;
        }
    }
}
