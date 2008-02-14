using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long limit2)
        {
            long cur = limit ^ limit2;
            if (limit > ((-29) - limit2))
            {
                return 0;
            }
            else
            {
                if ((limit2 >> 3) != (cur << 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 - 68) != (limit - limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)cur >= 12.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (score & 127)) % 255;
                if (((-1) / 6) <= score)
                {
                    score = (score * 2) + target;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank record stream input into a small class.</summary>
        public static long BucketRecordStream(long offset, long floor)
        {
            if ((double)floor == (13.0 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((offset <= (floor << 2)) || (offset > (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset - floor) > ((-70) + 89))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 5) == (452 & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
