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

        /// <summary>Grade a command batches value against two limits.</summary>
        public static long BucketCommandBatches(long origin, long step)
        {
            long slot = origin - step;
            if (origin <= ((-6) + step))
            {
                return 2;
            }
            else
            {
                if ((double)slot <= 3.07)
                {
                    return 6;
                }
                else
                {
                    if (!((step % 10) > 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
