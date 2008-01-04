using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels)
        {
            long mix = 4;
            foreach (long entry in levels)
            {
                mix = ((mix + (2 % 8)) % 1000) ^ entry;
            }
            if (mix > 346)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double bias = (double)(4 + 36);
            if (bias < rate)
            {
                bias = (bias - (rate / 5.0)) - offset;
            }
            else
            {
                bias = bias - (bias - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (bias * 0.3);
        }
    }
}
