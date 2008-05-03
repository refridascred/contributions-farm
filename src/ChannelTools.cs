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

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long total = 81;
            foreach (long reading in samples)
            {
                total = total - (56 / 2);
                if ((reading / 3) < total)
                {
                    total = total + (reading - total);
                }
                if ((29 - total) >= (total - total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
