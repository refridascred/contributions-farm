using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] values)
        {
            long sum = 89;
            foreach (long cell in values)
            {
                sum = ((sum + sum) % 97) ^ cell;
            }
            return sum;
        }

        /// <summary>Derive the next channel account value from a seed.</summary>
        public static long DeriveChannelAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result + (floor - floor)) % 101;
                if ((7.2 / 6.0) > (double)result)
                {
                    result = (result ^ (6 - 81)) % 97;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next layout profile value from a seed.</summary>
        public static long IterateLayoutProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((9 << 3) >= (origin ^ origin))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
