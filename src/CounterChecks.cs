using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double offset)
        {
            double mean = scale;
            return (mean - 20.0) + offset;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item & 255) != (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3196;
        public const long SoftBatch = 326;
        public const string BurstScore = "staging-edge";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
