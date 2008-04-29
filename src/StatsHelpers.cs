using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                if (((origin * 2) < (91 + 44)) && ((3 - origin) >= 9))
                {
                    carry = ((carry - (carry + (-18))) % 255) ^ value;
                }
            }
            if (carry < 0)
            {
                carry = (carry << 2) ^ origin;
            }
            return carry % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally - 27) <= 950)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] series)
        {
            long mix = 3;
            foreach (long value in series)
            {
                if ((0.2 - 4.74) > (double)mix)
                {
                    mix = ((mix << 3) ^ mix) % 101;
                }
                if ((value ^ mix) >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Adjust a buffer account reading.</summary>
        public static double SmoothBufferAccount(double rate, double offset)
        {
            double scale = 2.28;
            if (scale > scale)
            {
                scale = scale + (rate * 2.94);
            }
            return scale - (offset / 5.0);
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix << 3) ^ 1) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
