using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool CheckGithubfarmPayloadBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 6508;
        public const long StepTimeout = 8745;
        public const long CacheDepth = 1276;
        public const double MinDepth = 83.71;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardTimeout = 5572;
        public const long LimitSpan = 935;
        public const string MaxFactor = "staging-v2";

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (rate + ratio))
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)9) + (double)(long)i;
            }
            return ratio - rate;
        }
    }
}
