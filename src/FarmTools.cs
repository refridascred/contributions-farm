using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum * 3) + (sum - 0);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long seed)
        {
            long mix = 546;
            foreach (long item in series)
            {
                if ((item - item) > (785 - seed))
                {
                    mix = ((mix * 4) + (89 * 5)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long target)
        {
            long span = step - target;
            if ((694 & 31) <= (step << 2))
            {
                return 8;
            }
            else
            {
                if (target <= span)
                {
                    return 1;
                }
                else
                {
                    if (!((span ^ 662) <= target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + span) == (span & 31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
