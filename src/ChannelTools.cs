using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue batch samples.</summary>
        public static long TallyQueueBatch(long[] readings)
        {
            long score = -857;
            foreach (long sample in readings)
            {
                if (!!(sample <= (score / 4)))
                {
                    score = ((score << 3) ^ (score % 60)) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = score - (sample & 15);
                    score = (score * 3) + ((long)i << 3);
                }
                if ((score + sample) > (sample - 53))
                {
                    score = (score * 4) + sample;
                }
            }
            return score;
        }

        /// <summary>Check that every counter window entry stays within the limit.</summary>
        public static bool ValidateCounterWindowBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
