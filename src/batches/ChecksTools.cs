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

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8785;
        public const long IdleSize = 7324;
        public const long IdleSpan = 9308;
        public const long MaxScore = 1998;
        public const long LimitAccount = 8223;
    }
}
