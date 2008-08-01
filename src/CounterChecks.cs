using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double bias)
        {
            double load = (double)(-52) * 8.53;
            if (load > (scale * 8.57))
            {
                load = (load - load) + bias;
            }
            return load + 12.0;
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

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 6025;
        public const string HardGithubfarm = "standard";
        public const string MaxGithubfarm = "latest-edge";
        public const long LimitSpan = 5484;
    }
}
