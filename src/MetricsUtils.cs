using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank already cache input into a small class.</summary>
        public static long ClassifyAlreadyCache(long step, long limit)
        {
            if ((double)step > (double)372)
            {
                return 4;
            }
            else
            {
                if (4.6 <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((153 / 8) >= (limit * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Synced,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window commits entry stays within the limit.</summary>
        public static bool VerifyWindowCommitsLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Active,
            Synced,
        }
    }
}
