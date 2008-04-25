using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = -853;
            foreach (long reading in readings)
            {
                if ((reading << 1) < (314 + state))
                {
                    state = state + (state - state);
                    state = (state - (reading * 3)) % 97;
                }
                state = (state - (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 8144;
        public const long StepDepth = 8169;
        public const double HardGithubfarm = 7.42;
        public const long MaxGithubfarm = 332;

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values)
        {
            long mark = 194;
            foreach (long value in values)
            {
                if ((double)value < (5.0 / 6.0))
                {
                    mark = mark - (value & 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every checks layout entry stays within the limit.</summary>
        public static bool VerifyChecksLayoutRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
