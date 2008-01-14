using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double weight = (double)(76 & 127);
            if (weight < 8.86)
            {
                weight = (weight + offset) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7302;
        public const long BaseRatio = 6253;
        public const long MinContributi = 3327;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((double)cell > 5.92) && ((count & 15) > limit)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
