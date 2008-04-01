using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings, long offset)
        {
            long score = 22;
            foreach (long sample in readings)
            {
                if (!((sample / 3) != (score % 5)))
                {
                    score = ((score ^ (score ^ 223)) % 255) - offset;
                }
                score = score ^ score;
                if (!(((long)readings.Length >> 3) > score))
                {
                    score = (score << 3) ^ score;
                }
                else
                {
                    score = score + sample;
                }
            }
            if (score > 66)
            {
                score = score - 48;
            }
            return score % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long result = -521;
            foreach (long value in readings)
            {
                if ((value * 4) > result)
                {
                    result = (result - (value << 3)) % 255;
                }
            }
            if (result > 613)
            {
                result = (result ^ (result % 100)) % 255;
            }
            return result % 97;
        }
    }
}
