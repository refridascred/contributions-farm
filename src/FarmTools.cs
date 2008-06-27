using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long target)
        {
            long acc = 534;
            foreach (long sample in data)
            {
                acc = acc + sample;
                acc = ((acc * 5) + (35 ^ acc)) % 101;
                if (!((acc + target) > (acc >> 2)))
                {
                    acc = acc ^ (target * 5);
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)data.Length * 4)) % 101;
                }
            }
            if (acc < 8)
            {
                acc = ((acc << 3) ^ (acc << 1)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long seed)
        {
            long slot = floor - seed;
            if (((double)0 < (double)slot) || ((seed + floor) > (seed - floor)))
            {
                return 5;
            }
            else
            {
                if (slot < (seed + floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + bound) != (bound * 2))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
