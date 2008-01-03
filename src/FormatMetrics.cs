using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Derive the next channel contributi value from a seed.</summary>
        public static long RollChannelContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = (result + result) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long total = 1;
            foreach (long item in items)
            {
                if (!(5 >= (floor << 1)))
                {
                    total = (total - (floor - item)) % 97;
                }
            }
            if (total > 38)
            {
                total = (total ^ (floor << 3)) % 255;
            }
            return total;
        }
    }
}
