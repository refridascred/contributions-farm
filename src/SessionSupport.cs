using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank commits order input into a small class.</summary>
        public static long GradeCommitsOrder(long offset, long offset2)
        {
            if ((offset - offset2) < offset2)
            {
                return 3;
            }
            else
            {
                if (offset2 > ((-27) + 7))
                {
                    return 1;
                }
                else
                {
                    if (!((offset2 + offset) >= (977 ^ offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset2 * 5) > offset2) && (offset <= (offset / 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm graph entry stays within the limit.</summary>
        public static bool ValidateFarmGraphRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double scale = weight;
            if (scale >= (double)871)
            {
                scale = scale + (floor + 7.12);
            }
            return scale - 1.6;
        }
    }
}
