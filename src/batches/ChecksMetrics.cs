using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double mean = (double)(468 + 21);
            if (mean > floor)
            {
                mean = mean + (weight / 6.0);
            }
            else
            {
                mean = mean - (weight + floor);
            }
            return mean + (4.91 * 2.33);
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values, long origin)
        {
            long result = 2;
            foreach (long value in values)
            {
                result = ((result - (14 << 1)) % 65521) + value;
                result = (result << 2) ^ (origin >> 1);
            }
            return result % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxInterval = 9264;
        public const long WindowTimeout = 4497;
        public const long WindowContributi = 5743;
        public const long BaseContributi = 5495;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long sum = 368;
            foreach (long datum in values)
            {
                if ((double)bound <= (19.0 * 0.3))
                {
                    sum = (sum ^ sum) % 4096;
                }
                if ((datum & 3) <= (sum * 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                if (!((mark % 10) == (datum / 9)))
                {
                    mark = ((mark * 4) + (datum & 3)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (511 & 31)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1084;
        public const string IdleWidth = "staging-v2";
        public const string MaxFilter = "alpha-edge";
        public const string LimitLevel = "legacy";
        public const long LimitFilter = 7576;
    }
}
