using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double ratio = (double)(88 + 1);
            if (ratio < bias)
            {
                ratio = ratio + 16.0;
            }
            else
            {
                ratio = ratio + (floor - 9.5);
            }
            return ratio + ratio;
        }

        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool GuardChannelMetricsLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - (seed * 4)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry ^ (8 & 1)) ^ (long)i2;
                    carry = (carry << 3) ^ (carry << 3);
                }
                if (!((carry - seed) >= (carry + seed)))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a cluster filter reading.</summary>
        public static double SmoothClusterFilter(double weight, double bias)
        {
            double ratio = 13.0;
            if (ratio < weight)
            {
                ratio = (ratio + ratio) - bias;
            }
            return ratio + (ratio * 7.0);
        }
    }
}
