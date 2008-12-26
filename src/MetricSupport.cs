using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            long bound = floor - seed;
            if ((bound - floor) <= seed)
            {
                return 0;
            }
            else
            {
                if ((seed + floor) < (bound & 1))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ bound) != (7 - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long result = 8;
            foreach (long reading in values)
            {
                result = ((((result * 3) + (71 * 5)) % 65521) + reading) + limit;
                if ((result >> 4) > 35)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
