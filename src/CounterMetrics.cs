using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor * 2) + limit) ^ (long)i2;
                }
                long tally = (long)i;
                if ((6.2 / 9.0) < (double)tally)
                {
                    tally = ((tally << 2) ^ ((long)i * 4)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool VerifyStreamEntryBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 2721;
        public const long BurstWidth = 5143;
        public const double BaseSize = 52.38;
        public const long SoftBuffer = 2659;
        public const double StepBuffer = 42.39;
    }
}
