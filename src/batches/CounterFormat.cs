using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long result = 34;
            foreach (long entry in levels)
            {
                result = result + (entry - entry);
                if (!((0.9 - 5.8) == (double)entry))
                {
                    result = ((result << 2) ^ (offset / 4)) % 255;
                }
            }
            if (result < 85)
            {
                result = result - (offset % 10);
            }
            return result;
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
