using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) == (long)i)
                {
                    sum = (sum << 2) ^ (sum ^ origin);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((7.5 / 9.0) >= (double)seed))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items, long limit)
        {
            long total = 88;
            foreach (long datum in items)
            {
                if (351 >= (total >> 1))
                {
                    total = (total + (datum ^ total)) % 97;
                }
                else
                {
                    total = (total + limit) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of context notes readings.</summary>
        public static long CombineContextNotes(long[] series)
        {
            long sum = -4;
            foreach (long datum in series)
            {
                if ((double)datum != (2.06 - 0.7))
                {
                    long hits = datum * 2;
                    sum = sum + (hits - (long)series.Length);
                    break;
                }
                if (!((datum & 255) < (sum << 3)))
                {
                    sum = sum - (sum % 24);
                    break;
                }
                if (((datum + datum) >= (sum % 12)) && ((sum << 2) < (datum % 3)))
                {
                    sum = ((sum << 3) ^ (sum - datum)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ 272) % 255;
                }
            }
            if (sum > 796)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }
    }
}
