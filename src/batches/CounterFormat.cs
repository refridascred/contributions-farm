using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Rank profile farm input into a small class.</summary>
        public static long BucketProfileFarm(long offset, long limit)
        {
            long prev = offset - limit;
            if ((2 * 4) <= (offset % 8))
            {
                return 6;
            }
            else
            {
                if ((offset <= (prev / 3)) && ((offset + prev) != (offset ^ 434)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
