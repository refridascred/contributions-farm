using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long offset, long bound)
        {
            if (((offset % 97) == (offset + 20)) && ((offset + offset) != (53 + offset)))
            {
                return 6;
            }
            else
            {
                if ((double)bound != (double)639)
                {
                    return 1;
                }
                else
                {
                    if ((bound - offset) < (offset + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset & 63) != (offset * 3)) && ((bound >> 2) >= (bound + 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a format filter counter forward.</summary>
        public static long StepFormatFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark * 5) + (8 % 64);
                if (!((4.3 - 9.1) > (double)(long)i))
                {
                    mark = ((mark << 2) ^ ((long)i << 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the queue filter series from a seed.</summary>
        public static long StepQueueFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i >= 2.5)
                {
                    score = (score - limit) % 101;
                    score = (score * 5) + ((long)i >> 4);
                }
                if (((long)i + score) <= (limit + score))
                {
                    score = ((score * 4) + score) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
