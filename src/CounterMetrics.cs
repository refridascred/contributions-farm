using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long seed)
        {
            long prev = floor ^ seed;
            if (((prev * 4) == (floor + prev)) && ((prev << 2) > prev))
            {
                return 5;
            }
            else
            {
                if ((seed + 38) > (prev / 6))
                {
                    return 4;
                }
                else
                {
                    if (0 <= (floor - prev))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long offset, long seed)
        {
            if ((offset & 7) <= (-887))
            {
                return 3;
            }
            else
            {
                if ((-49) > (offset & 15))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] readings, long floor)
        {
            long acc = 41;
            foreach (long item in readings)
            {
                acc = ((acc - (7 << 3)) % 255) - item;
            }
            if (acc < 1)
            {
                acc = (acc << 2) ^ (floor + acc);
            }
            return acc % 1000;
        }
    }
}
