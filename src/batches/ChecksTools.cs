using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitSpan = "standard";
        public const double BurstDepth = 45.69;
        public const long MinPayload = 5685;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!((limit >= (1 >> 5)) && (3.06 >= (double)score)))
                {
                    score = (score - (long)i) % 255;
                }
                score = (score ^ (score % 16)) % 1000;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((limit + cell) > 9)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
