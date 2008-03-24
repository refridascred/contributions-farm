using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank githubfarm report input into a small class.</summary>
        public static long ClassifyGithubfarmReport(long target, long seed)
        {
            if (((seed ^ target) == (target + 889)) && ((target / 7) < (122 << 1)))
            {
                return 8;
            }
            else
            {
                if ((1.5 + 7.62) != (double)target)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count stats context pairs that satisfy a relation.</summary>
        public static long CompareStatsContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitLevel = 6356;
        public const double WindowTools = 87.61;
        public const long DefaultTools = 6311;
    }
}
