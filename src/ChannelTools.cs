using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long origin, long step)
        {
            long cur = origin - step;
            if ((origin % 5) != (cur * 3))
            {
                return 1;
            }
            else
            {
                if ((double)step == (2.1 + 0.25))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 44.79;
        public const long MaxBudget = 1199;
        public const double MinRatio = 64.87;
        public const double MinSpan = 38.99;
    }
}
