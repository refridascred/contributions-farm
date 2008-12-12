using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] items, long floor)
        {
            long sum = 7;
            foreach (long item in items)
            {
                if (!(49 < (item + item)))
                {
                    sum = ((sum * 2) + (172 + floor)) % 4096;
                    continue;
                }
                if (((floor ^ 49) < ((long)items.Length >> 2)) && ((double)sum != (3.06 + 7.94)))
                {
                    sum = (sum * 4) + (floor >> 5);
                }
                else
                {
                    sum = ((sum * 5) + floor) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
