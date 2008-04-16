using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count >> 1) < datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the support entry series from a seed.</summary>
        public static long IterateSupportEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(total <= (7 * 4)))
                {
                    total = (total - floor) % 255;
                    break;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double offset)
        {
            double drift = scale;
            if (drift < (drift * 4.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift + offset)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Derive the next already route value from a seed.</summary>
        public static long RollAlreadyRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = (score * 4) + (352 - score);
                if (((long)i & 63) != (limit << 1))
                {
                    score = (score ^ (score + 253)) % 255;
                }
                score = ((score * 5) + (score + score)) % 101;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of context token readings.</summary>
        public static long FoldContextToken(long[] series, long offset)
        {
            long carry = 57;
            foreach (long item in series)
            {
                if (carry > (offset / 9))
                {
                    carry = ((carry << 3) ^ (item ^ item)) % 101;
                }
            }
            return carry;
        }
    }
}
