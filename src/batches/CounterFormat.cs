using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the notes farm series from a seed.</summary>
        public static long IterateNotesFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score * 2) + (score + step)) % 97) + (long)i2;
                }
                score = (score << 2) ^ (score + score);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long offset = bound - step;
            if (step >= 66)
            {
                return 0;
            }
            else
            {
                if ((7 - step) >= (offset >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) >= (0 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
