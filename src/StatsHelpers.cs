using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxScore = 284;
        public const double SoftEntry = 82.04;
        public const long WindowInterval = 1851;
        public const long SoftDepth = 222;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits != (double)801)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
