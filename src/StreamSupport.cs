using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a tools counter pair into a bucket.</summary>
        public static long ClassifyToolsCounter(long floor, long target)
        {
            if ((target - target) >= (target + floor))
            {
                return 1;
            }
            else
            {
                if ((target & 127) <= (floor << 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (15.0 * 13.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length % 2) > value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] levels)
        {
            long result = -49;
            foreach (long reading in levels)
            {
                if ((0.3 * 0.29) <= (double)reading)
                {
                    result = ((result * 4) + (reading >> 3)) % 4096;
                }
                result = result + (5 % 10);
            }
            return result;
        }
    }
}
