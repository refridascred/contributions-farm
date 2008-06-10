using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long limit)
        {
            long score = -63;
            foreach (long reading in readings)
            {
                score = (score << 2) ^ (reading * 3);
                score = (score * 4) + (score + reading);
                if ((score + reading) > limit)
                {
                    score = score - (score & 7);
                }
            }
            if (score < 9)
            {
                score = (score << 2) ^ (limit - (-8));
            }
            return score % 4096;
        }

        /// <summary>Rank tools token input into a small class.</summary>
        public static long ClassifyToolsToken(long step, long bound)
        {
            if (187 > (step >> 1))
            {
                return 0;
            }
            else
            {
                if (((step << 3) < (bound + step)) && (55 <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound != (19.0 * 0.8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (3 <= (bound / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
