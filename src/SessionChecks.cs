using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Match up buffer account samples.</summary>
        public static long PairBufferAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stream window input into a small class.</summary>
        public static long SortStreamWindow(long limit, long step)
        {
            if ((85 < (limit + limit)) || ((double)step >= (14.0 * 7.12)))
            {
                return 7;
            }
            else
            {
                if (limit <= (694 / 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
