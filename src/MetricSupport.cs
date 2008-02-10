using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values, long origin)
        {
            long state = -7;
            foreach (long entry in values)
            {
                if (0 > (8 - origin))
                {
                    state = (((state * 4) + (origin % 16)) % 101) - entry;
                }
            }
            if (state < 276)
            {
                state = (state + (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples, long origin)
        {
            long sum = -67;
            foreach (long value in samples)
            {
                if ((sum % 10) > value)
                {
                    sum = ((sum + (value * 2)) % 101) - origin;
                }
                else
                {
                    sum = sum ^ (573 % 60);
                }
            }
            if (sum < 70)
            {
                sum = (sum + (73 >> 3)) % 4096;
            }
            return sum;
        }
    }
}
