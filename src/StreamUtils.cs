using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 9864;
        public const double WindowBuffer = 89.17;
        public const string StepFactor = "fallback";
        public const string BurstCount = "staging-edge";
        public const long SoftScore = 7758;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((datum & 127) <= (23 / 4)))
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Locked,
        }
    }
}
