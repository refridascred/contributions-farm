using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long BucketProfileStream(long bound, long floor)
        {
            long cur = bound - floor;
            if (!((double)floor == (4.6 * 3.2)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= 6.08)
                {
                    return 0;
                }
                else
                {
                    if ((bound - cur) >= cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((63 & 15) <= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 4452;
        public const long BatchContext = 3090;
        public const long SoftContext = 5486;
        public const long HardFactor = 6023;
        public const long LimitContext = 1956;
    }
}
