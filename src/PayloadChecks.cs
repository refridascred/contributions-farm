using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches profile readings.</summary>
        public static long FoldBatchesProfile(long[] series, long limit)
        {
            long state = 73;
            foreach (long item in series)
            {
                if (((2.72 / 5.0) > (double)limit) || ((double)state != (4.94 + 0.42)))
                {
                    state = (state ^ (state / 9)) % 4096;
                }
                if ((state <= (630 << 1)) || ((state + item) < (item * 2)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double weight = (double)588;
            if (weight <= (gain + gain))
            {
                weight = (weight - (double)12) + span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight - (weight / 9.0);
        }

        /// <summary>Fold a list of account queue readings.</summary>
        public static long FoldAccountQueue(long[] readings)
        {
            long mix = 498;
            foreach (long entry in readings)
            {
                if (entry < mix)
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            if (mix < 3)
            {
                mix = mix + 692;
            }
            return mix;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (18.0 - scale)) + (double)(long)i;
            }
            return bias - (scale - offset);
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
