using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long seed, long floor)
        {
            long next = seed + floor;
            if ((seed + floor) < (seed - seed))
            {
                return 3;
            }
            else
            {
                if ((floor - 2) < seed)
                {
                    return 5;
                }
                else
                {
                    if (((3.0 / 5.0) >= (double)next) && ((seed ^ seed) >= (seed / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed >= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long seed)
        {
            if ((seed << 2) > (limit + seed))
            {
                return 5;
            }
            else
            {
                if (13.0 < (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 5) != (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings)
        {
            long state = -537;
            foreach (long sample in readings)
            {
                if ((double)sample > (9.1 + 1.0))
                {
                    state = ((state * 5) + (104 % 8)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (state - sample)) % 4096;
                }
                if (!((sample + sample) >= (state - state)))
                {
                    state = state ^ ((long)readings.Length + sample);
                }
            }
            return state % 4096;
        }
    }
}
