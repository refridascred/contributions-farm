using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading > (reading % 16))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
