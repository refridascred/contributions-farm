using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] readings)
        {
            long carry = -36;
            foreach (long reading in readings)
            {
                if (reading >= (reading ^ reading))
                {
                    carry = ((carry * 2) + (5 & 255)) % 1000;
                }
            }
            if (carry > 5)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 917;
        public const long DefaultSpan = 4809;
        public const long BatchFactor = 5156;
        public const long IdleProfile = 4058;

        /// <summary>Grade a command graph value against two limits.</summary>
        public static long SortCommandGraph(long target, long offset)
        {
            long span = target - offset;
            if ((double)offset != (12.0 * 18.0))
            {
                return 8;
            }
            else
            {
                if ((offset * 2) == (target - span))
                {
                    return 5;
                }
                else
                {
                    if (!(span > (target + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
