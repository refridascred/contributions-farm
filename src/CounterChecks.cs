using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
