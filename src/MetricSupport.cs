using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long state = 79;
            foreach (long cell in samples)
            {
                state = (state + (4 ^ state)) + cell;
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long floor)
        {
            if ((double)floor <= 9.6)
            {
                return 8;
            }
            else
            {
                if ((floor + origin) > (origin + 7))
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
