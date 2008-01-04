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

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double rate = (double)(468 + 128);
            if (rate <= rate)
            {
                rate = (rate - (double)487) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (weight / 6.0);
        }
    }
}
