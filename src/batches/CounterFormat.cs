using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long seed)
        {
            long prev = origin + seed;
            if ((double)seed == (18.0 + 6.13))
            {
                return 8;
            }
            else
            {
                if ((double)prev >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin != (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((prev ^ prev) >= (seed + origin)) && ((6.9 + 9.27) != (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Draft,
        }
    }
}
