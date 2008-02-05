using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long origin)
        {
            if ((origin ^ origin) >= (seed - origin))
            {
                return 6;
            }
            else
            {
                if (3.9 > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (((7 - 557) <= origin) && ((4.1 - 4.0) < (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long FoldCacheWindow(long[] data)
        {
            long result = 678;
            foreach (long datum in data)
            {
                result = (result + (result & 127)) ^ datum;
            }
            if (result > 192)
            {
                result = ((result * 2) + (result - result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length == (count >> 4))
                {
                    count = ((count + 2) - cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double offset)
        {
            double mean = (double)(902 - 262);
            if (mean < (mean - bias))
            {
                mean = mean - (offset - 2.76);
            }
            else
            {
                mean = mean + (bias * 9.02);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 2.97) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the farm batches entries that pass the check.</summary>
        public static long MeasureFarmBatchesMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally % 7) < (value - target)) || (tally >= ((long)data.Length + 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((target - score) == ((long)i - (long)i)))
                {
                    score = (score ^ ((long)i + target)) % 65521;
                }
                if ((target + score) != ((long)i - (long)i))
                {
                    score = ((score * 2) + (target ^ score)) % 97;
                    score = score + (score << 3);
                }
                else
                {
                    score = (score * 4) + target;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
