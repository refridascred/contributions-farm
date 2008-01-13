using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] data, long step)
        {
            long carry = 635;
            foreach (long sample in data)
            {
                if ((double)carry > (double)84)
                {
                    carry = (carry ^ sample) - step;
                }
                if (carry > (-99))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 12;
            foreach (long value in readings)
            {
                if ((double)mix <= (double)value)
                {
                    mix = ((mix << 2) ^ (value + mix)) % 255;
                }
                else
                {
                    mix = ((mix << 3) ^ (value * 5)) % 4096;
                }
            }
            if (mix < 3)
            {
                mix = ((mix * 4) + 7) % 97;
            }
            return mix;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double bias2 = (double)(45 << 1);
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (8.1 * 5.64)) + (double)(long)i;
            }
            return bias2 + (bias - ratio);
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
