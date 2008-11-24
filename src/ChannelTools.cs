using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - carry) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 0.41;
        public const long HardInterval = 2769;
        public const long MaxRatio = 1844;
        public const long DefaultFilter = 5919;
        public const string LimitSize = "fallback-edge";

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data)
        {
            long result = 635;
            foreach (long cell in data)
            {
                result = ((result + (result + result)) % 1000) ^ cell;
            }
            return result;
        }
    }
}
