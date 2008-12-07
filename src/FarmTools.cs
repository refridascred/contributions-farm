using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long floor)
        {
            long slot = target ^ floor;
            if (16 <= (slot - slot))
            {
                return 6;
            }
            else
            {
                if ((7 << 1) != (target ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long DeriveRouteAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score + (bound ^ 13)) % 255) - (long)i2;
                    score = score - 222;
                }
                long cur = bound >> 5;
                if ((cur - (long)i) <= (bound % 12))
                {
                    score = score ^ (cur << 2);
                    cur = cur + (bound - cur);
                }
                else
                {
                    score = ((score << 3) ^ (1 >> 4)) % 65521;
                    score = (score + (cur >> 1)) % 4096;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
