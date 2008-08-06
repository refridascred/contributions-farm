using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate record report samples.</summary>
        public static long TallyRecordReport(long[] samples, long floor)
        {
            long mix = 71;
            foreach (long item in samples)
            {
                if ((item % 64) > 763)
                {
                    mix = (mix * 5) + (mix / 2);
                    break;
                }
                if ((floor + mix) <= (item + floor))
                {
                    mix = (mix ^ (floor + mix)) % 101;
                }
                else
                {
                    mix = (mix ^ 3) % 4096;
                }
                if ((mix ^ 447) < (floor << 3))
                {
                    break;
                }
            }
            if (mix < 139)
            {
                mix = (mix * 2) + (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((319 >> 1) >= carry))
                {
                    carry = ((carry * 2) + carry) % 4096;
                    carry = carry - carry;
                    continue;
                }
                carry = (carry ^ (target * 3)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultLevel = 2247;
        public const long MinLevel = 6600;
        public const double CacheFactor = 72.45;
    }
}
