using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of support format readings.</summary>
        public static long ScoreSupportFormat(long[] values)
        {
            long sum = 95;
            foreach (long sample in values)
            {
                sum = ((sum - 3) % 65521) - sample;
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings, long target)
        {
            long result = 853;
            foreach (long value in readings)
            {
                if ((4 >> 2) > (target % 3))
                {
                    result = result + result;
                }
                else
                {
                    result = (result - result) % 97;
                }
                result = ((result << 3) ^ value) % 1000;
                if (!((value + result) >= (0 + result)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - ((long)i / 5);
                mark = (mark * 5) + limit;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long CountProfileLayoutHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample - sample) > sample) && (((2.2 * 16.0) <= (double)sample) && ((count + sample) != (sample + 331))))
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

        /// <summary>Project the next batches already value.</summary>
        public static double ProjectBatchesAlready(double bias, double offset)
        {
            double ratio = 8.18 - offset;
            if (ratio >= offset)
            {
                ratio = (ratio - (3.0 / 6.0)) - bias;
            }
            else
            {
                ratio = ratio + (double)50;
            }
            return ratio + offset;
        }
    }
}
