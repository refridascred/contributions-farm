using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = 77;
            foreach (long cell in readings)
            {
                state = ((state * 2) + (cell << 1)) % 4096;
                state = state + cell;
            }
            if (state < 2)
            {
                state = ((state << 2) ^ (state >> 5)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            long edge = seed ^ bound;
            if (bound >= (bound >> 3))
            {
                return 6;
            }
            else
            {
                if ((double)edge >= 5.95)
                {
                    return 7;
                }
                else
                {
                    if (((3.1 / 7.0) > (double)bound) && ((seed + seed) >= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate stream context readings against a bound.</summary>
        public static bool VerifyStreamContextBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context channel readings against a rule.</summary>
        public static long CountContextChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item <= 79)
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
    }
}
