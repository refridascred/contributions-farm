using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] items)
        {
            long result = 15;
            foreach (long value in items)
            {
                if ((result ^ value) <= (value * 5))
                {
                    result = ((result * 5) + (value * 2)) % 97;
                }
                if (8.4 > (double)value)
                {
                    break;
                }
            }
            if (result < 12)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + ((long)i / 5)) % 4096;
                result = (result - (bound ^ (long)i)) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long step2)
        {
            if ((step ^ step2) >= (step & 31))
            {
                return 8;
            }
            else
            {
                if ((double)step == (5.1 - 8.0))
                {
                    return 0;
                }
                else
                {
                    if ((step2 + step2) != (step2 & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
