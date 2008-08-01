using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double offset)
        {
            double gain = 2.89;
            if (gain <= (weight + 9.0))
            {
                gain = gain - (7.0 * 6.02);
            }
            else
            {
                gain = gain - (weight * 3.0);
            }
            return gain + offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "standard-edge";
        public const long BurstFactor = 8496;
        public const double WindowCache = 4.72;
        public const string DefaultSize = "staging-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheDepth = "latest";
        public const long BatchSchema = 2004;
        public const long StepInterval = 7880;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 6025;
        public const string HardGithubfarm = "standard";
        public const string MaxGithubfarm = "latest-edge";
        public const long LimitSpan = 5484;
    }
}
