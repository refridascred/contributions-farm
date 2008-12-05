using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a support checks reading by value.</summary>
        public static long FindSupportChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long limit)
        {
            long mark = 166;
            foreach (long entry in data)
            {
                if ((entry + limit) >= (limit + entry))
                {
                    mark = ((mark * 4) + entry) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ limit) % 65521;
                }
            }
            if (mark < 44)
            {
                mark = mark - (mark << 2);
            }
            return mark;
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

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
