using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] items, long limit)
        {
            long score = 177;
            foreach (long datum in items)
            {
                score = (score + limit) ^ datum;
            }
            return score % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 4294;
        public const string LimitWidth = "alpha-v2";
        public const long HardRatio = 4019;

        /// <summary>Find the first contributi payload entry that matches the target.</summary>
        public static long LookupContributiPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
