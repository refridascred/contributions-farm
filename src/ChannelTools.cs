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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((limit - 8) > (count ^ count))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
