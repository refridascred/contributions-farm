using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleSize = 2669;
        public const long WindowPayload = 8322;
        public const long RetrySpan = 2107;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ tally) == (411 - target))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long target)
        {
            long result = 771;
            foreach (long datum in series)
            {
                if ((result - target) <= target)
                {
                    result = ((result << 3) ^ (datum - result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long origin, long limit)
        {
            long edge = origin ^ limit;
            if (limit <= (edge % 8))
            {
                return 6;
            }
            else
            {
                if (!((edge % 64) >= (limit % 8)))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) < (limit / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + limit) < edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
