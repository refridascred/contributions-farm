using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ ((long)i / 4);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstInterval = 7450;
        public const long BaseGithubfarm = 1637;
        public const double StepGithubfarm = 0.12;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((575 - seen) < (seen << 2)))
                {
                    seen = (seen + 1) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
