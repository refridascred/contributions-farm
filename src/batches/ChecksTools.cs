using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinRatio = 88.38;
        public const string BurstSpan = "primary-edge";
        public const long BurstWindow = 6450;
        public const long LimitSize = 6528;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if ((carry + carry) < carry)
                {
                    carry = (carry + 6) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftSpan = 3508;
        public const string WindowWidth = "local-1";
        public const long BatchRecord = 6280;
        public const long BurstFactor = 9756;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!((offset / 2) != (carry + (long)i)))
                {
                    carry = carry - (offset & 3);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
