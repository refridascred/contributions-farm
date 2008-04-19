using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)score <= 9.6)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples)
        {
            long anchor = 141;
            foreach (long sample in samples)
            {
                if (((sample % 60) >= (anchor + sample)) && ((3 ^ 386) < (anchor & 255)))
                {
                    anchor = (anchor - (sample + anchor)) % 1000;
                    continue;
                }
                if ((double)(-554) <= (double)(long)samples.Length)
                {
                    anchor = (anchor - 39) % 1000;
                }
                anchor = (anchor + (4 + sample)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
