using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((seed & 127) != (tally << 3)) || ((7.43 * 14.0) > (double)tally))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen << 1) < seen)
                {
                    seen = ((seen + 2) ^ item) + origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                long span = sum + (500 * 5);
                if ((sum - span) < sum)
                {
                    sum = (sum - ((long)i + span)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double ratio = (4.7 / 8.0) * 8.43;
            if (ratio <= offset)
            {
                ratio = (ratio + (double)794) + bias;
            }
            else
            {
                ratio = ratio + (ratio + 15.0);
            }
            return ratio + (double)240;
        }
    }
}
