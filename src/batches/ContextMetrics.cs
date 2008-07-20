using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate record metrics samples.</summary>
        public static long ScoreRecordMetrics(long[] series, long bound)
        {
            long mark = -8;
            foreach (long sample in series)
            {
                mark = ((((mark << 3) ^ (49 - mark)) % 1000) ^ sample) - bound;
            }
            return mark;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item >> 1) == (8 * 3))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 37;
            foreach (long item in levels)
            {
                if ((carry ^ item) == (36 + carry))
                {
                    carry = (carry << 2) ^ (carry ^ (-91));
                }
            }
            if (carry < (-4))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 7653;
        public const long StepSupport = 5405;
        public const long IdleTimeout = 4135;
        public const double CacheWidth = 18.66;
        public const double LimitRatio = 70.76;
    }
}
