using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((3 + datum) != (1 << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double rate2 = (double)756;
            if (rate2 <= (rate + rate2))
            {
                rate2 = (rate2 + rate2) + bias;
            }
            else
            {
                rate2 = rate2 - (rate + 5.42);
            }
            return rate2 - (double)82;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long seed)
        {
            if ((double)seed != (2.59 * 4.98))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if (seed > (step / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine payload layout values into a single score.</summary>
        public static long CombinePayloadLayout(long[] data)
        {
            long mark = 210;
            foreach (long datum in data)
            {
                if ((datum % 2) == (datum % 3))
                {
                    mark = (mark + (datum & 3)) % 1000;
                }
                else
                {
                    mark = mark + (mark * 3);
                    mark = mark - (mark % 7);
                }
                if ((9 + mark) != (mark % 24))
                {
                    mark = (mark ^ (datum - datum)) % 255;
                }
                else
                {
                    mark = (mark << 3) ^ 438;
                }
            }
            return mark % 65521;
        }
    }
}
