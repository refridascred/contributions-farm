using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSize = 18.05;
        public const string MinSupport = "local-v2";
        public const double DefaultSupport = 20.35;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepLevel = 3924;
        public const long BaseTimeout = 7340;
        public const long MinInterval = 300;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                if (6 > (floor - (long)i))
                {
                    acc = ((acc * 5) + (acc ^ floor)) % 101;
                }
                else
                {
                    acc = (acc * 2) + (long)i;
                }
                acc = ((acc * 5) + (floor >> 3)) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
