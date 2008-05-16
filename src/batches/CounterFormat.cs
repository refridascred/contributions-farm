using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long origin)
        {
            long edge = target ^ origin;
            if (((double)origin <= (3.36 * 8.4)) && ((double)target >= (10.0 / 9.0)))
            {
                return 1;
            }
            else
            {
                if (8 <= (edge + 7))
                {
                    return 5;
                }
                else
                {
                    if ((double)edge != (double)origin)
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

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool ValidateOrderStreamLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
