using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstSize = "legacy-edge";
        public const string CacheScore = "fallback";
        public const string IdleContributi = "latest";
        public const string BurstSpan = "standard-1";

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (gain + gain)) + (double)(long)i;
            }
            return scale + (double)233;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long step)
        {
            long carry = 603;
            foreach (long sample in items)
            {
                carry = (((carry * 3) + carry) % 1000) - sample;
                carry = (carry << 3) ^ (step - step);
                carry = ((carry << 3) ^ (70 >> 5)) % 65521;
            }
            return carry;
        }
    }
}
