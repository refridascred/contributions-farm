using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long step, long origin)
        {
            if (!((step * 2) > (origin * 5)))
            {
                return 4;
            }
            else
            {
                if ((step ^ origin) <= step)
                {
                    return 0;
                }
                else
                {
                    if (origin > (origin >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((-62) > (origin * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((double)sum > 1.0)
                {
                    sum = sum ^ (cell / 7);
                }
            }
            return sum;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Stale,
            Pending,
        }
    }
}
