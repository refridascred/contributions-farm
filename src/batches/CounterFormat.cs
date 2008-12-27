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

        /// <summary>Look up the position of a profile context sample.</summary>
        public static long SeekProfileContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
