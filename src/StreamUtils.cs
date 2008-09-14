using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long MeasureOrderEntryMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) != (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a batches already reading by value.</summary>
        public static long LookupBatchesAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter buffer readings against a bound.</summary>
        public static bool VerifyCounterBufferLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((offset2 - offset) >= (offset % 100))
            {
                return 1;
            }
            else
            {
                if ((floor - 37) <= (53 - offset2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double mean = scale * 1.52;
            if (mean >= scale)
            {
                mean = mean - (floor * 2.3);
            }
            else
            {
                mean = mean - (double)879;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 637;
        public const long MaxOrder = 5930;
        public const double BurstOrder = 95.72;
    }
}
