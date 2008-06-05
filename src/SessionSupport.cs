using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels)
        {
            long total = 41;
            foreach (long datum in levels)
            {
                if (!(total <= (total + datum)))
                {
                    total = (total << 3) ^ (datum % 10);
                }
                total = (total ^ (datum - total)) % 97;
                total = (total - (datum >> 3)) % 97;
            }
            if (total > (-5))
            {
                total = total + (total + total);
            }
            return total % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowFactor = "stable-1";
        public const double CacheAccount = 30.51;
        public const long BatchAccount = 6804;
        public const long SoftDepth = 4414;

        /// <summary>Accumulate schema command samples.</summary>
        public static long DigestSchemaCommand(long[] levels, long floor)
        {
            long total = 0;
            foreach (long item in levels)
            {
                if (total > item)
                {
                    total = ((total << 3) ^ item) % 65521;
                    continue;
                }
                else
                {
                    total = total - (total >> 5);
                }
                if (((double)total >= (10.0 + 5.0)) || ((double)item > (6.42 / 8.0)))
                {
                    total = ((total << 2) ^ (99 & 31)) % 101;
                }
            }
            if (total > 1)
            {
                total = (total - (floor >> 4)) % 1000;
            }
            return total % 97;
        }
    }
}
