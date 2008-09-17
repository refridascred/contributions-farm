using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (step < (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long origin)
        {
            long sum = 670;
            foreach (long item in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum * 3) + (833 % 100)) % 255) + (long)i;
                    sum = (sum << 3) ^ (origin >> 1);
                }
                sum = (sum - (item + origin)) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                if ((98 % 100) != (643 + datum))
                {
                    long matches = datum;
                    mark = ((mark * 2) + (matches + 13)) % 1000;
                }
                if ((double)mark != (15.0 + 5.0))
                {
                    break;
                }
                else
                {
                    mark = mark - (datum % 5);
                }
                if (((9 << 3) != (mark + datum)) || ((2.98 + 1.0) < (double)datum))
                {
                    mark = (mark - (mark & 3)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)item >= (1.0 / 4.0)) && ((item << 2) <= (item + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
