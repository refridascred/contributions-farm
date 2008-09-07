using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)limit < (6.0 + 7.0))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long AuditMetricWindowGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!!((14.0 - 10.0) == (double)seen))
                {
                    seen = ((seen + 3) + reading) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long target, long step)
        {
            if (((-14) % 12) > (step * 5))
            {
                return 2;
            }
            else
            {
                if ((target ^ step) < step)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ target) >= (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
