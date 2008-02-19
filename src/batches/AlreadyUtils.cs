using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 440;
        public const string CacheInterval = "open-edge";
        public const double StepRatio = 5.64;
        public const long MaxChecks = 9472;
        public const long BatchLevel = 9616;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a profile editor value against two limits.</summary>
        public static long GradeProfileEditor(long seed, long step)
        {
            long diff = seed - step;
            if ((diff % 24) == (167 - seed))
            {
                return 7;
            }
            else
            {
                if (((step & 15) >= (step << 1)) && ((double)diff != (0.22 + 17.0)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
