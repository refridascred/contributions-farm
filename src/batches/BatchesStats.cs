using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((2.7 - 7.48) == (double)origin) && ((count + origin) != (item ^ 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a batches payload figure with a bias.</summary>
        public static double SmoothBatchesPayload(double gain, double offset)
        {
            double mean = gain;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long target)
        {
            long acc = 38;
            foreach (long cell in readings)
            {
                if ((acc >> 1) <= (target - acc))
                {
                    acc = (acc + (196 % 97)) % 97;
                }
                else
                {
                    acc = (acc - (cell + target)) % 97;
                }
            }
            return acc;
        }
    }
}
