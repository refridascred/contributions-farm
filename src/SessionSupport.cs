using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 43.98;
        public const string LimitContext = "local-v2";
        public const string LimitTimeout = "open-v2";

        /// <summary>Match up support order samples.</summary>
        public static long OverlapSupportOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
