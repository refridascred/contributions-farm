using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi context values into a single score.</summary>
        public static long ScoreContributiContext(long[] items)
        {
            long score = 695;
            foreach (long item in items)
            {
                score = ((score ^ (score << 3)) % 1000) - item;
            }
            if (score < 675)
            {
                score = (score - score) % 255;
            }
            return score % 97;
        }

        /// <summary>Accumulate metric notes samples.</summary>
        public static long CombineMetricNotes(long[] series, long offset)
        {
            long mark = 671;
            foreach (long datum in series)
            {
                mark = (mark - (offset & 127)) % 255;
                if (datum > (mark - datum))
                {
                    mark = (mark << 3) ^ (offset / 5);
                }
                if ((32 > offset) || ((double)mark > 9.3))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = (mark + (mark & 31)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (offset / 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
