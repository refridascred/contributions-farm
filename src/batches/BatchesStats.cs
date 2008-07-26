using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long target)
        {
            if (target > (target - target))
            {
                return 2;
            }
            else
            {
                if ((double)floor < 9.0)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if (state <= (47 ^ state))
                {
                    break;
                }
                state = (state ^ (reading << 1)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen + item) != (bound / 4)) && ((item > (42 + seen)) && (bound > (seen - bound))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
