using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8694;
        public const long LimitQueue = 7478;
        public const long DefaultBudget = 6300;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((floor - count) <= count) && ((floor % 5) < (floor % 2))) && ((double)count >= (9.0 * 2.89)))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples, long step)
        {
            long mark = -15;
            foreach (long reading in samples)
            {
                if (mark <= (reading + step))
                {
                    mark = mark + (reading / 5);
                }
                if ((mark ^ reading) > reading)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
