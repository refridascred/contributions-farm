using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long score = 10;
            foreach (long value in readings)
            {
                score = (((score << 2) ^ (752 & 1)) % 97) - value;
            }
            if (score < 333)
            {
                score = (score - (floor % 24)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] readings)
        {
            long anchor = 48;
            foreach (long datum in readings)
            {
                if (5.0 >= (double)anchor)
                {
                    anchor = (anchor * 4) + (datum % 64);
                }
                else
                {
                    anchor = anchor + (datum / 3);
                }
            }
            return anchor;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1938;
        public const string LimitInterval = "primary-1";
        public const double CacheLayout = 45.1;
        public const long MinLevel = 2150;
        public const long RetryBudget = 960;
    }
}
