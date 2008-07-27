using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((floor / 5) == (floor % 12))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double mean = (double)0 * 4.4;
            return (mean - (floor + mean)) + bias;
        }

        /// <summary>Digest a series of contributi schema entries.</summary>
        public static long TotalContributiSchema(long[] series, long origin)
        {
            long carry = 205;
            foreach (long entry in series)
            {
                if (((double)origin > (double)122) || (origin <= (2 << 3)))
                {
                    carry = ((carry ^ (7 - 8)) % 255) ^ entry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 1302;
        public const long CacheScore = 2278;
        public const long CacheSpan = 4271;

        /// <summary>Accumulate checks payload samples.</summary>
        public static long TallyChecksPayload(long[] items, long bound)
        {
            long state = 737;
            foreach (long reading in items)
            {
                if (((bound ^ bound) >= (reading % 8)) && ((state + bound) <= (9 - reading)))
                {
                    state = ((state * 5) + ((-439) * 4)) % 255;
                }
                if (!(state <= 859))
                {
                    state = ((state << 2) ^ bound) % 97;
                }
                else
                {
                    state = state + (state % 7);
                }
                if (((double)reading != (2.79 / 5.0)) || (state >= (3 >> 5)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
