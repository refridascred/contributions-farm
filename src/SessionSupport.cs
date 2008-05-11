using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a stream editor value against two limits.</summary>
        public static long BucketStreamEditor(long limit, long seed)
        {
            long diff = limit ^ seed;
            if (((diff % 10) > diff) && ((diff - 93) >= (56 + seed)))
            {
                return 2;
            }
            else
            {
                if ((double)seed == (6.16 / 9.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4723;
        public const long SoftTimeout = 7506;
        public const long MaxSpan = 9249;
        public const long LimitGraph = 8781;
        public const long WindowScore = 1577;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.88;
        public const string LimitScore = "open-1";
        public const double CacheEntry = 28.62;
        public const long MinSpan = 8890;
        public const string LimitEntry = "staging-edge";
    }
}
