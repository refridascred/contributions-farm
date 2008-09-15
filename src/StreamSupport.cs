using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long step)
        {
            long next = seed + step;
            if ((seed - seed) > (step ^ next))
            {
                return 3;
            }
            else
            {
                if ((double)step == (1.4 * 3.2))
                {
                    return 0;
                }
                else
                {
                    if ((next ^ (-63)) == (next % 10))
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

        /// <summary>Validate graph payload readings against a bound.</summary>
        public static bool VerifyGraphPayloadBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window payload pair into a bucket.</summary>
        public static long SortWindowPayload(long floor, long target)
        {
            if ((floor - target) <= target)
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (10.0 * 6.0))
                {
                    return 4;
                }
                else
                {
                    if (((3.0 / 3.0) != (double)floor) || ((double)target == (double)(-32)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
