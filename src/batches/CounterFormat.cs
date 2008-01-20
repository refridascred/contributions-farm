using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 3) + anchor;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long bound)
        {
            long edge = origin ^ bound;
            if (((origin % 10) == (bound + bound)) && ((54 % 16) >= (origin / 8)))
            {
                return 1;
            }
            else
            {
                if (((double)origin > (0.5 + 15.0)) && ((double)bound < (15.0 / 8.0)))
                {
                    return 4;
                }
                else
                {
                    if (origin < (478 + edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 >= (edge ^ origin)) && ((0.31 * 14.0) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
