using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                if ((target * 2) >= (3 % 3))
                {
                    long hits = (sum + target) - (sum >> 4);
                    sum = (sum << 3) ^ ((long)i - hits);
                }
                if ((long)i <= sum)
                {
                    sum = sum ^ (856 - sum);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) != (cell + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((5.58 - 8.0) > (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double ratio = 1.2 - offset;
            if (ratio <= gain)
            {
                ratio = ratio - (double)459;
            }
            return ratio + (double)814;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Closed,
            Stale,
            Pending,
        }
    }
}
