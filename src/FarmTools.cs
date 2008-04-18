using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data, long origin)
        {
            long result = 179;
            foreach (long value in data)
            {
                if (!((double)origin >= (double)value))
                {
                    result = (result - (origin * 4)) % 255;
                }
                else
                {
                    result = (result + (result ^ 750)) % 97;
                }
            }
            if (result < 915)
            {
                result = ((result * 5) + (origin & 3)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long limit, long origin)
        {
            long gap = limit + origin;
            if (gap > (gap - gap))
            {
                return 8;
            }
            else
            {
                if ((origin & 31) == (origin - 950))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (10.0 / 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((gap + (-298)) == (limit ^ 87))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer queue readings.</summary>
        public static long CompareBufferQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
