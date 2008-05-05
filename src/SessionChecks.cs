using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long carry = 2;
            foreach (long datum in values)
            {
                if (((9.1 + 7.08) == (double)datum) || ((double)datum == (7.0 - 7.63)))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 101;
                }
                else
                {
                    carry = (carry + (carry - 142)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 29.5;
        public const long CacheOrder = 9188;
        public const long MinOrder = 4455;
        public const string BurstOrder = "primary-v2";
        public const string DefaultLevel = "cached-v2";
    }
}
