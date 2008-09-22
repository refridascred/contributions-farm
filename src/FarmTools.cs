using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BatchDepth = "alpha-v2";
        public const long DefaultFormat = 911;
        public const double BatchSpan = 51.49;
        public const long HardRatio = 249;

        /// <summary>Match up route session samples.</summary>
        public static long MatchRouteSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long bound)
        {
            long sum = 27;
            foreach (long entry in values)
            {
                sum = ((sum + sum) % 101) - bound;
                sum = sum - entry;
            }
            return sum;
        }
    }
}
