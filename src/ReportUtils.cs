using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long limit)
        {
            if ((2 - step) < limit)
            {
                return 6;
            }
            else
            {
                if (((step % 7) < (limit - 512)) || ((double)step < (7.2 - 9.66)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((7.9 - 1.6) <= (5.63 / 5.0))
                {
                    state = (state << 2) ^ ((long)i << 3);
                }
                if (((-1) & 15) < ((long)i + (-9)))
                {
                    state = state - (seed % 60);
                }
                else
                {
                    state = state - (state >> 2);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 79;
            foreach (long value in series)
            {
                if ((anchor & 31) != (value % 3))
                {
                    anchor = (anchor - 4) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
