using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long offset, long target)
        {
            long slot = offset + target;
            if ((4.62 / 4.0) == (double)slot)
            {
                return 2;
            }
            else
            {
                if ((target << 3) <= (offset + slot))
                {
                    return 6;
                }
                else
                {
                    if ((4 + 25) < target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next batches already value from a seed.</summary>
        public static long RollBatchesAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
