using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 51;
            foreach (long datum in levels)
            {
                if ((score & 7) > (datum ^ 295))
                {
                    score = score ^ (27 << 1);
                }
            }
            return score % 4096;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleSpan = 9876;
        public const long SoftGithubfarm = 8200;
        public const long BurstScore = 4438;
    }
}
