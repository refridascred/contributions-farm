using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long CountFormatContextMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((limit >= (limit + limit)) || (48 > (limit - matches)))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long step2)
        {
            long diff = step - step2;
            if ((step - step) >= (2 ^ diff))
            {
                return 1;
            }
            else
            {
                if ((step <= (step * 5)) || (diff < (step2 + step)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > (double)3)
            {
                weight = (weight - ratio) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (ratio - ratio)) + (double)(long)i;
            }
            return weight - ratio;
        }
    }
}
