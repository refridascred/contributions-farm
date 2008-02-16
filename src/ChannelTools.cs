using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + acc) % 4096;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

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
