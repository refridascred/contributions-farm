using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long limit)
        {
            if ((double)21 <= (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed - limit) <= (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if (87 < (seed - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((offset ^ offset2) != (955 >> 5))
            {
                return 3;
            }
            else
            {
                if (((offset2 >> 3) != (offset2 + offset)) && ((floor + offset) >= offset2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
