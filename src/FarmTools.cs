using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stats metric values into a single score.</summary>
        public static long TotalStatsMetric(long[] samples)
        {
            long total = 7;
            foreach (long cell in samples)
            {
                if ((8.2 + 3.7) != (double)cell)
                {
                    total = ((total << 2) ^ (cell >> 5)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long mix = 67;
            foreach (long datum in levels)
            {
                mix = mix - (datum % 100);
            }
            if (mix < 39)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 4096;
        }
    }
}
