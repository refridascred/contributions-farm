using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8193;
        public const double WindowBudget = 13.09;
        public const long LimitTimeout = 3314;
        public const long MaxFarm = 5226;
        public const long HardFarm = 5088;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools filter sample.</summary>
        public static long FindToolsFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks batch values into a single score.</summary>
        public static long FoldChecksBatch(long[] samples, long limit)
        {
            long mark = 654;
            foreach (long value in samples)
            {
                mark = (mark + (value >> 3)) + limit;
            }
            return mark % 1000;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long limit)
        {
            if (!((limit + limit) >= (limit + 1)))
            {
                return 8;
            }
            else
            {
                if ((target - limit) != (limit + target))
                {
                    return 5;
                }
                else
                {
                    if ((limit - limit) >= (target * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)limit < (double)target) || ((4.0 * 6.0) <= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
