using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchBudget = "primary-1";
        public const string IdleRatio = "stable";
        public const long MaxCommand = 4956;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step & 15) != (carry / 6))
                {
                    carry = ((carry << 2) ^ (743 & 127)) % 65521;
                }
                carry = ((carry << 3) ^ carry) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long step)
        {
            long total = -294;
            foreach (long value in samples)
            {
                total = ((total ^ (value << 1)) % 1000) + step;
            }
            if (total > 77)
            {
                total = total - (total + 15);
            }
            return total;
        }
    }
}
