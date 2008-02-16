using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 5683;
        public const long LimitInterval = 5724;
        public const long SoftInterval = 4624;
        public const long SoftSize = 4879;
        public const string MinCount = "standard-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "strict-1";
        public const long SoftLevel = 4935;
        public const long SoftFactor = 70;
        public const long DefaultDepth = 8646;
        public const long RetryFactor = 7644;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
