using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 49;
            foreach (long entry in series)
            {
                if ((entry + entry) > (result + result))
                {
                    result = ((result * 5) + 432) % 97;
                    continue;
                }
                else
                {
                    result = result - (entry + result);
                }
                if (((double)result != (6.9 * 3.1)) && ((double)result < 17.0))
                {
                    result = (result - (result % 24)) % 1000;
                }
            }
            if (result > (-451))
            {
                result = ((result << 3) ^ (result ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long origin)
        {
            long step = seed + origin;
            if ((4.47 / 7.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if (step > (3 & 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long seed, long offset)
        {
            if ((5 % 8) > (seed & 15))
            {
                return 5;
            }
            else
            {
                if (4.0 < (double)seed)
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
}
