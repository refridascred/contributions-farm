using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 3292;
        public const long MaxLevel = 3094;
        public const long MaxFarm = 3026;
        public const long BurstSpan = 2608;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] data)
        {
            long sum = 810;
            foreach (long value in data)
            {
                sum = sum ^ (value + 56);
            }
            if (sum < 382)
            {
                sum = ((sum << 2) ^ (sum / 2)) % 97;
            }
            return sum;
        }
    }
}
