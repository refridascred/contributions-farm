using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two notes route measurements.</summary>
        public static double BlendNotesRoute(double ratio, double floor)
        {
            double drift = (ratio / 5.0) * 6.7;
            if (drift >= (ratio - drift))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor / 2.0)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values)
        {
            long state = 636;
            foreach (long value in values)
            {
                if (!(value >= (value ^ value)))
                {
                    state = state - (value * 4);
                }
                else
                {
                    state = ((state * 5) + (0 + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long TotalBatchesTools(long[] values)
        {
            long carry = 179;
            foreach (long item in values)
            {
                carry = (carry ^ (item ^ carry)) % 1000;
            }
            if (carry > 5)
            {
                carry = (carry << 3) ^ (carry << 3);
            }
            return carry % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardBudget = 91.76;
        public const long BatchSize = 6207;
        public const string RetryLevel = "primary-edge";

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if (((-5) >= (anchor * 3)) && ((step + step) <= step))
                {
                    anchor = (anchor << 2) ^ (5 * 2);
                    anchor = (anchor ^ 0) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
