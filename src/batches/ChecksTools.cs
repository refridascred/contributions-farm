using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel schema samples.</summary>
        public static long CombineChannelSchema(long[] samples, long limit)
        {
            long anchor = 285;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ (94 << 1)) ^ reading) - limit;
            }
            return anchor;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long bound2)
        {
            if ((bound * 4) <= (bound2 >> 1))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 3) < (bound * 4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
