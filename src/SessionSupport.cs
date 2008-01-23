using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 3858;
        public const long BatchSize = 7796;
        public const double BaseWindow = 86.32;
        public const long StepWindow = 527;
        public const long BatchWindow = 5755;

        /// <summary>Scale a queue farm figure with a bias.</summary>
        public static double ProjectQueueFarm(double gain, double floor)
        {
            double rate = (double)(47 + (-924));
            if (rate >= (rate / 9.0))
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + gain;
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long CombineTokenProfile(long[] items, long step)
        {
            long mark = 737;
            foreach (long entry in items)
            {
                mark = (mark + mark) - entry;
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ (step % 97)) % 97;
            }
            return mark;
        }
    }
}
