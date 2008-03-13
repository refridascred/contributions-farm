using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long target)
        {
            if ((target / 7) <= target)
            {
                return 6;
            }
            else
            {
                if (((double)floor >= (4.41 - 3.29)) && (64 > (floor * 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRatio = "strict-1";
        public const string MinRatio = "alpha-edge";
        public const long StepRoute = 1716;
        public const long BatchLevel = 2763;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
