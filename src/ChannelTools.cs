using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 7655;
        public const long DefaultCount = 6731;
        public const long LimitWidth = 5623;
        public const long BaseSpan = 7891;

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
