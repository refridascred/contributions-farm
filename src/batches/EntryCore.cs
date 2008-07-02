using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= rate)
            {
                rate2 = rate2 + 2.42;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + span) + (double)(long)i;
            }
            return rate2 - (span / 8.0);
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftSize = "cached-1";
        public const long BatchChecks = 6899;
        public const string CacheInterval = "strict-1";
        public const long WindowScore = 3729;
    }
}
