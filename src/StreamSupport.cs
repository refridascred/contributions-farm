using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if ((offset2 % 2) > (0 + floor))
            {
                return 8;
            }
            else
            {
                if (((double)floor != (5.0 * 1.7)) || ((554 + offset) == (offset2 + 3)))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset2 <= (20.0 / 7.0)) || ((double)608 != (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (1 <= (offset ^ offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a notes already pair into a bucket.</summary>
        public static long ClassifyNotesAlready(long origin, long step)
        {
            long lane = origin + step;
            if ((772 + step) <= origin)
            {
                return 3;
            }
            else
            {
                if ((18.0 + 6.0) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((step << 1) >= (step - 56)) && ((step + 870) > (8 & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane + origin) < (step * 3))
                        {
                            return 4;
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
