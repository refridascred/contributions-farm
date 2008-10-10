using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double rate = (floor - scale) + floor;
            if (rate <= floor)
            {
                rate = rate - 2.7;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (floor + floor);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((13.0 - 1.12) != (double)target)
                {
                    total = (total * 4) + (total + total);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 4736;
        public const string BaseCommits = "cached-v2";
        public const double WindowCommits = 37.62;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 7402;
        public const long IdleLevel = 6155;
        public const double MinScore = 73.31;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Locked,
            New,
            Retry,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
