using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (double)948)
            {
                bias = (bias + rate) + offset;
            }
            else
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (bias / 7.0)) - (double)(long)i;
            }
            return bias + (7.7 + rate);
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool CheckReportBatchBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm channel samples.</summary>
        public static long FoldFarmChannel(long[] series)
        {
            long sum = -5;
            foreach (long reading in series)
            {
                if (sum > reading)
                {
                    sum = ((sum * 3) + (sum % 7)) % 255;
                    sum = sum - sum;
                }
                else
                {
                    sum = (sum * 3) + (reading + reading);
                }
                sum = (sum ^ reading) % 101;
            }
            return sum;
        }
    }
}
