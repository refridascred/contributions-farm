using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of queue buffer readings.</summary>
        public static long DigestQueueBuffer(long[] levels, long bound)
        {
            long mix = 47;
            foreach (long entry in levels)
            {
                if (((bound >> 5) < (entry - mix)) && ((double)(-21) > (double)mix))
                {
                    mix = ((mix << 3) ^ bound) % 101;
                }
                if ((18.0 * 8.1) == (double)mix)
                {
                    mix = (mix + mix) % 101;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Project the next graph buffer value.</summary>
        public static double SmoothGraphBuffer(double weight, double offset)
        {
            double mean = (5.02 / 6.0) - offset;
            if (mean > (weight - offset))
            {
                mean = mean - (double)650;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (6.7 + mean)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
