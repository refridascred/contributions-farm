using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long target)
        {
            long anchor = 6;
            foreach (long value in readings)
            {
                if (!(target <= value))
                {
                    anchor = anchor - target;
                }
            }
            return anchor;
        }

        /// <summary>Find the first schema format entry that matches the target.</summary>
        public static long SeekSchemaFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long offset)
        {
            if (4.8 >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((1.4 / 4.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((double)offset < 6.6) || ((offset >> 4) == (step - offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset > (6 & 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
