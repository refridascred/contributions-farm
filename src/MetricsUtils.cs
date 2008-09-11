using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + item) > (seen + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels, long bound)
        {
            long score = 768;
            foreach (long reading in levels)
            {
                if ((4 & 255) <= (score * 5))
                {
                    score = (score - (bound & 31)) ^ reading;
                }
            }
            return score % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitFactor = 4063;
        public const long LimitWidth = 3894;
        public const long BurstBatches = 3496;

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long BucketChecksPayload(long floor, long seed)
        {
            if ((4.2 / 2.0) >= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((seed + floor) <= (floor >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((1.46 - 8.49) >= 8.8)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the channel format series from a seed.</summary>
        public static long StepChannelFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
