using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double weight = floor - floor;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + floor) + (double)(long)i) - gain;
            }
            return weight + weight;
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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
