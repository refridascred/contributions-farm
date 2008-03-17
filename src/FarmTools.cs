using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score + score;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long origin)
        {
            if ((origin + 583) != (origin & 7))
            {
                return 1;
            }
            else
            {
                if (origin >= (origin * 4))
                {
                    return 2;
                }
                else
                {
                    if ((4.94 + 15.0) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin << 3) <= origin) || (limit > (limit / 9)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
