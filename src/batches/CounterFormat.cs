using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items)
        {
            long acc = 31;
            foreach (long cell in items)
            {
                acc = (acc - cell) % 65521;
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long target2)
        {
            if (((target & 3) < (111 + target)) || ((11.0 - 9.2) == (double)target))
            {
                return 4;
            }
            else
            {
                if (((double)target >= (double)378) && ((target2 * 5) <= target))
                {
                    return 0;
                }
                else
                {
                    if ((8.11 > (double)target) && ((target << 1) >= (target2 % 100)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((21 >> 1) > (target2 % 3))
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
        }
    }
}
