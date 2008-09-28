using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long step)
        {
            long mix = 4;
            foreach (long cell in values)
            {
                mix = (mix + (step ^ cell)) % 255;
            }
            if (mix > 867)
            {
                mix = ((mix << 2) ^ (step << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Audit metrics context readings against a rule.</summary>
        public static long CountMetricsContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value << 2) != (9 >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 3751;
        public const long BaseCache = 4568;
        public const long LimitCount = 3593;
        public const long SoftCache = 6690;

        /// <summary>Measure how many channel queue samples are out of range.</summary>
        public static long MeasureChannelQueueHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches * 3) < (datum * 5))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Validate format profile readings against a bound.</summary>
        public static bool ValidateFormatProfileLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
