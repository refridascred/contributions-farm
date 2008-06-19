using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                total = ((total * 5) + (reading * 2)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Classify a context order pair into a bucket.</summary>
        public static long GradeContextOrder(long offset, long limit)
        {
            if (limit >= 9)
            {
                return 4;
            }
            else
            {
                if ((1.58 * 8.05) <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset ^ limit) > 1)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= (ratio - span))
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio - ratio)) - (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long bound)
        {
            long span = floor + bound;
            if (((11 * 3) == (floor & 255)) && ((span * 5) > span))
            {
                return 6;
            }
            else
            {
                if (((double)span == (14.0 - 4.9)) && (floor > (bound & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)span != (4.3 - 5.3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
