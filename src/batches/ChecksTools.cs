using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits batches pairs that satisfy a relation.</summary>
        public static long PairCommitsBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long step)
        {
            long delta = floor - step;
            if ((step * 2) < (delta % 24))
            {
                return 8;
            }
            else
            {
                if ((step << 3) >= ((-93) - floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= 2.0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step % 2) > step) && ((floor >> 5) < delta))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long result = 751;
            foreach (long reading in levels)
            {
                if (((5.0 * 0.5) > (double)reading) || ((reading + result) >= 50))
                {
                    result = (result ^ (reading ^ 860)) % 97;
                    result = ((result << 3) ^ (reading >> 5)) % 97;
                    continue;
                }
                else
                {
                    result = (result ^ result) % 255;
                    result = (result << 3) ^ (-12);
                }
                result = result - (result * 5);
                if (result > 912)
                {
                    result = ((result << 3) ^ result) % 101;
                }
                else
                {
                    result = ((result * 3) + (result + result)) % 255;
                }
            }
            if (result > 3)
            {
                result = (result ^ (result << 1)) % 97;
            }
            return result % 97;
        }
    }
}
