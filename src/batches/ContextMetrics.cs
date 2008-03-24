using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((16.0 * 7.0) <= (double)seen)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 1995;
        public const string RetryCommand = "staging-v2";
        public const double IdleCommand = 18.02;
        public const string DefaultCommand = "staging-1";
        public const string SoftCommand = "latest-edge";

        /// <summary>Rank githubfarm support input into a small class.</summary>
        public static long ClassifyGithubfarmSupport(long bound, long origin)
        {
            if ((double)bound != (2.4 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((origin + bound) >= origin)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
