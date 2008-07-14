using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long SortGraphCache(long origin, long limit)
        {
            if ((1 / 6) < origin)
            {
                return 0;
            }
            else
            {
                if (origin < (limit << 3))
                {
                    return 1;
                }
                else
                {
                    if ((50 & 127) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit > (89 - 99))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long BucketStreamRecord(long bound, long floor)
        {
            if ((double)bound < (4.77 - 9.4))
            {
                return 8;
            }
            else
            {
                if (!((bound % 24) != (floor << 2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if (sample >= (sample + (long)readings.Length))
                {
                    state = (state + (state >> 2)) % 101;
                }
            }
            return state % 65521;
        }
    }
}
