using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                mix = ((mix * 2) + entry) % 4096;
            }
            return mix;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + sum) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long step)
        {
            if ((double)step > (5.0 + 9.9))
            {
                return 1;
            }
            else
            {
                if ((limit + limit) == (limit * 5))
                {
                    return 3;
                }
                else
                {
                    if ((6.3 + 3.8) < (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)step < (0.4 / 9.0)) || ((8.7 - 8.0) == (double)limit))
                        {
                            return 7;
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
}
