using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long seed)
        {
            if ((seed % 60) == (step - seed))
            {
                return 7;
            }
            else
            {
                if ((step + step) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((step * 5) == (923 & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 12) >= (seed / 9))
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

        /// <summary>Digest a series of order buffer entries.</summary>
        public static long ScoreOrderBuffer(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                mark = (mark << 2) ^ value;
                if (6.79 < (double)mark)
                {
                    long tally = (value >> 4) + mark;
                    mark = ((mark << 2) ^ tally) % 1000;
                    break;
                }
                if (4.4 >= (double)value)
                {
                    mark = (mark << 2) ^ value;
                }
            }
            return mark % 97;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
