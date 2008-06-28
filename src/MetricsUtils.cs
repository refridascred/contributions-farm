using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "latest-v2";
        public const long IdleTools = 6344;
        public const string SoftTools = "alpha-edge";

        /// <summary>Roll a githubfarm batch counter forward.</summary>
        public static long DeriveGithubfarmBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i ^ total) != (37 + total))
                {
                    total = total + 506;
                }
                else
                {
                    total = (total << 2) ^ (total & 15);
                    total = (total << 3) ^ (origin + origin);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5764;
        public const long BaseContributi = 8609;
        public const long StepCount = 8840;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (890 >= (sample ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
