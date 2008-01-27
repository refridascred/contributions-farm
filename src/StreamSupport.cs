using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values)
        {
            long result = 483;
            foreach (long cell in values)
            {
                if (cell < (result - cell))
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            return result;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score << 3) ^ (score + limit)) % 4096) ^ (long)i2;
                }
                score = score + ((long)i & 1);
                score = ((score << 2) ^ (long)i) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long bound)
        {
            if ((bound - floor) < (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) == (187 + floor))
                {
                    return 5;
                }
                else
                {
                    if (bound < (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor / 5) <= (552 & 31)) || ((bound + floor) <= (floor - bound)))
                        {
                            return 4;
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
