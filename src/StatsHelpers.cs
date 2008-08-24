using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the already counter series from a seed.</summary>
        public static long DeriveAlreadyCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((carry + seed) != (seed + carry))
                {
                    carry = carry + (seed - (long)i);
                    carry = ((carry << 2) ^ ((long)i + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 7990;
        public const long HardDepth = 3445;
        public const long MinWidth = 7985;
        public const string BaseRatio = "fallback-1";
        public const double BurstWindow = 53.85;
    }
}
