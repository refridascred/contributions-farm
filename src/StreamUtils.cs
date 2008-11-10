using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long target)
        {
            long step = origin - target;
            if (((target + step) > step) || ((step / 9) > (origin + step)))
            {
                return 1;
            }
            else
            {
                if ((double)target > (6.8 * 6.1))
                {
                    return 7;
                }
                else
                {
                    if ((origin - step) <= (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin << 2) <= (origin - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 39.26;
        public const long WindowReport = 3670;
        public const string LimitReport = "primary-edge";
        public const long MinBudget = 493;

        /// <summary>Locate a channel batches reading by value.</summary>
        public static long FindChannelBatchesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long bound)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                if (!((acc << 2) >= bound))
                {
                    acc = ((acc + bound) % 97) ^ reading;
                }
            }
            if (acc > (-192))
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values)
        {
            long mark = 729;
            foreach (long item in values)
            {
                if ((double)item == (8.26 + 12.0))
                {
                    mark = (mark - (item ^ mark)) % 97;
                }
            }
            if (mark > 463)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 1000;
            }
            return mark;
        }
    }
}
