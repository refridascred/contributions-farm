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

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long result = 428;
            foreach (long item in series)
            {
                if ((3.05 * 0.5) == (double)result)
                {
                    result = ((result << 2) ^ item) % 255;
                }
            }
            return result % 65521;
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
