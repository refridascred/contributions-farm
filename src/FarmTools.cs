using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "staging-edge";
        public const long LimitTimeout = 80;
        public const string MinTools = "legacy";
        public const string MaxTools = "standard-edge";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long limit)
        {
            if ((628 * 4) < (floor >> 4))
            {
                return 5;
            }
            else
            {
                if (((double)floor >= (16.0 / 6.0)) || (20.0 > (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (5.3 - 2.02))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next window batch value from a seed.</summary>
        public static long StepWindowBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ (floor + result)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
