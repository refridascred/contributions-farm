using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 6529;
        public const long StepGithubfarm = 3947;
        public const long BatchGithubfarm = 1960;
        public const long MinGithubfarm = 893;
        public const double IdleGithubfarm = 10.41;

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long limit)
        {
            long result = 84;
            foreach (long value in series)
            {
                result = (result ^ (value ^ limit)) % 255;
                if (((limit - result) != (result / 3)) || ((20.0 + 5.65) != (double)value))
                {
                    result = (result - value) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
